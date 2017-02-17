using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;
using EBDSystem.Util;
using System.Data;
using System.Windows.Forms;

namespace EBDSystem.BD
{
    class CidadeDAO:DAO
    {
        public bool inserir(CidadeEntity cidadeEntity)
        {
            cidade cidade = new cidade();
            int idEstado = getIdEstadoByString(cidadeEntity.Uf);
            cidade.id_estado = idEstado;
            cidade.nome = cidadeEntity.Nome;

            DB.cidades.InsertOnSubmit(cidade);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Cidade inserida com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cidadeEntity.Id = cidade.id;
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Cidade", Validator.INSERIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool editar(CidadeEntity cidadeEntity)
        {
            var query = from c in DB.cidades where c.id == cidadeEntity.Id select c;
            int idEstado = getIdEstadoByString(cidadeEntity.Uf);
            foreach (cidade ci in query)
            {
                ci.nome = cidadeEntity.Nome;
                ci.id_estado = idEstado;
            }
            try {
                DB.SubmitChanges();
                MessageBox.Show("Cidade editada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } catch(Exception ex){
                Validator.tratarErrosSql("Cidade", Validator.EDITAR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool excluir(int id)
        {
            var query = from c in DB.cidades where c.id == id select c;
            foreach (var cidade in query)
            {
                DB.cidades.DeleteOnSubmit(cidade);
            }
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Cidade excluída com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {                
                Validator.tratarErrosSql("Cidade", Validator.INSERIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public DataTable getCidades()
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Nome", typeof(String)),
                new DataColumn ("UF", typeof(String))
            });
            var query = from c in DB.cidades
                        from e in DB.estados
                        where c.id_estado == e.id
                        orderby c.nome
                        select new { c.id, c.nome, e.uf };

            foreach (var c in query)
            {
                dados.Rows.Add(new Object[] {c.id,c.nome,c.uf});
            }
            return dados;
        }

        public List<String> getUfs()
        {
            List<String> list = new List<string>();
            var query = from es in DB.estados select new { es.uf };
            foreach(var e in query)
            {
                list.Add(e.uf);
            }
            return list;
        }

        public int getIdEstadoByString(String uf)
        {
            var query = from e in DB.estados where e.uf == uf select new { e.id };
            int idEstado = 0;
            foreach (var est in query)
            {
                idEstado = est.id;
            }
            return idEstado;
        }

        public override DataTable getSource(string search)
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Cidade", typeof(String)),
                new DataColumn ("UF", typeof(String))
            });
            if (search != null)
            {
                var query = from c in DB.cidades                        
                            from e in DB.estados
                            where c.id_estado == e.id
                            where c.nome.Contains(search)
                            orderby c.nome
                            select new { c.id, c.nome, e.uf };
                Console.WriteLine(query.AsQueryable());

                foreach (var cid in query)
                {
                    dados.Rows.Add(new Object[] { cid.id, cid.nome, cid.uf });
                }
            }
            return dados;
        }

        public override Entity getEntityByIdentificador(int id)
        {
            CidadeEntity entidade = new CidadeEntity();
            var query = from c in DB.cidades
                        from e in DB.estados
                        where e.id == c.id_estado
                        where c.id == id
                        select new { c.id, c.id_estado, c.nome, e.uf };
            foreach (var cid in query)
            {
                entidade.Id = cid.id;
                entidade.Nome = cid.nome;
                entidade.IdEstado = cid.id_estado;
                entidade.Uf = cid.uf;
            }
            return entidade;
        }
    }
}
