using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;
using EBDSystem.Util;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EBDSystem.BD
{
    class BairroDAO:DAO
    {
        public bool inserir(BairroEntity bairroEntity)
        {
            bairro bairro = new bairro();
            bairro.nome = bairroEntity.Nome;
            bairro.id_cidade = bairroEntity.IdCidade;

            DB.bairros.InsertOnSubmit(bairro);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Bairro inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bairroEntity.Id = bairro.id;
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Bairro", Validator.INSERIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool editar(BairroEntity bairroEntity)
        {
            var query = from c in DB.bairros where c.id == bairroEntity.Id select c;
            foreach (bairro ci in query)
            {
                ci.nome = bairroEntity.Nome;
                ci.id_cidade = bairroEntity.IdCidade;
            }
            try {
                DB.SubmitChanges();
                MessageBox.Show("Bairro editado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } catch(Exception ex) {
                Validator.tratarErrosSql("Bairro", Validator.EDITAR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool excluir(int id)
        {
            var query = from b in DB.bairros where b.id == id select b;
            foreach (var bairro in query)
            {
                DB.bairros.DeleteOnSubmit(bairro);
            }
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Bairro excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Bairro", Validator.EXCLUIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public DataTable getBairros()
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Nome", typeof(String)),
                new DataColumn("ID cidade", typeof(Int32)),
                new DataColumn ("Cidade", typeof(String))
            });
            var query = from b in DB.bairros
                        from c in DB.cidades
                        from e in DB.estados
                        where b.id_cidade == c.id
                        where c.id_estado == e.id
                        select new { b.id, b.nome, id_cidade = c.id, cidade = c.nome+"-"+e.uf };

            foreach (var b in query)
            {
                dados.Rows.Add(new Object[] {b.id,b.nome,b.id_cidade, b.cidade});
            }
            return dados;
        }

        public override DataTable getSource(String search)
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Nome", typeof(String)),
                new DataColumn ("Cidade", typeof(String)),
                new DataColumn ("UF", typeof(String))
            });
            if (search != null)
            {
                var query = from b in DB.bairros
                            from c in DB.cidades
                            from e in DB.estados
                            where b.id_cidade == c.id
                            where c.id_estado == e.id
                            where b.nome.Contains(search)
                            orderby c.nome
                            select new { b.id, b.nome, cidade = c.nome, e.uf };
                foreach (var b in query)
                {
                    dados.Rows.Add(new Object[] { b.id, b.nome, b.cidade, b.uf });
                }
            }
            return dados;
        }

        public override Entity getEntityByIdentificador(int id)
        {
            BairroEntity entidade = new BairroEntity();
            var query = from b in DB.bairros
                        where b.id == id
                        select new {b.id, b.nome };
            foreach(var b in query)
            {
                entidade.Id = b.id;
                entidade.Nome = b.nome;
            }
            return entidade;
        }
    }
}
