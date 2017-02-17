using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;
using EBDSystem.Util;
using System.Windows.Forms;

namespace EBDSystem.BD
{
    class PessoaDAO : DAO
    {
        public bool inserir(PessoaEntity pessoaEntity)
        {
            pessoa pessoa= new pessoa();
            pessoa.nome = pessoaEntity.Nome;
            pessoa.data_nascimento = pessoaEntity.DataNascimento;
            pessoa.endereco = pessoaEntity.Endereco;
            pessoa.id_bairro = pessoaEntity.IdBairro;
            pessoa.telefone_principal = pessoaEntity.TelefonePrincipal;
            pessoa.telefone_secundario = pessoaEntity.TelefoneSecundario;
            pessoa.comentario = pessoaEntity.Comentario;
            pessoa.tipo = pessoaEntity.Tipo;
            pessoa.sexo = pessoaEntity.Sexo;
            pessoa.estado_civil = pessoaEntity.EstadoCivil;
            if (pessoaEntity.IdPai > 0)
            {
                pessoa.id_pai = pessoaEntity.IdPai;
            }
            if (pessoaEntity.IdMae >0)
            {
                pessoa.id_mae = pessoaEntity.IdMae;
            }
            if (pessoaEntity.IdConjuge>0)
            {
                pessoa.id_conjuge = pessoaEntity.IdConjuge;
            }
            pessoa.numero = pessoaEntity.Numero;
            pessoa.cep = pessoaEntity.Cep;

            DB.pessoas.InsertOnSubmit(pessoa);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Pessoa inserida com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pessoaEntity.Id = pessoa.id;
                if (pessoa.id_conjuge != null)
                {
                    var query = from p in DB.pessoas where p.id == pessoaEntity.IdConjuge select p;
                    foreach(var p in query)
                    {
                        p.id_conjuge = pessoaEntity.Id;
                        DB.SubmitChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Membro/Pessoa", Validator.INSERIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool editar(PessoaEntity pessoaEntity)
        {
            var query = from p in DB.pessoas
                        where p.id == pessoaEntity.Id
                        select p;
            int idConjugeAnt =0;

            try
            {
                foreach (pessoa pessoa in query)
                {
                    pessoa.nome = pessoaEntity.Nome;
                    pessoa.data_nascimento = pessoaEntity.DataNascimento;
                    pessoa.endereco = pessoaEntity.Endereco;
                    pessoa.id_bairro = pessoaEntity.IdBairro;
                    pessoa.telefone_principal = pessoaEntity.TelefonePrincipal;
                    pessoa.telefone_secundario = pessoaEntity.TelefoneSecundario;
                    pessoa.comentario = pessoaEntity.Comentario;
                    pessoa.tipo = pessoaEntity.Tipo;
                    pessoa.sexo = pessoaEntity.Sexo;
                    pessoa.estado_civil = pessoaEntity.EstadoCivil;
                    pessoa.numero = pessoaEntity.Numero;
                    pessoa.cep = pessoaEntity.Cep;
                    if (pessoaEntity.IdPai > 0)
                    {
                        pessoa.id_pai = pessoaEntity.IdPai;
                    }
                    if (pessoaEntity.IdMae > 0)
                    {
                        pessoa.id_mae = pessoaEntity.IdMae;
                    }
                    if(pessoaEntity.EstadoCivil.Equals(PessoaEntity.SOLTEIRO) && pessoa.conjuge != null)
                    {
                        idConjugeAnt = pessoa.conjuge.id;
                    }
                    if (pessoaEntity.IdConjuge > 0)
                    {
                        pessoa.id_conjuge = pessoaEntity.IdConjuge;
                        var sqlConjuge = from c in DB.pessoas where c.id == pessoaEntity.IdConjuge select c;
                        foreach (pessoa cj in sqlConjuge)
                        {
                            cj.id_conjuge = pessoaEntity.Id;
                            cj.estado_civil = pessoaEntity.EstadoCivil;
                        }
                    }
                }
                DB.SubmitChanges();
                var queryConj = from cj in DB.pessoas where cj.id_conjuge == pessoaEntity.Id select new { cj.id };
                foreach (var cj in queryConj)
                {
                    if (pessoaEntity.EstadoCivil.Equals(PessoaEntity.SOLTEIRO))
                    {
                        String sql = "update pessoa set id_conjuge = null, estado_civil = " + PessoaEntity.SOLTEIRO
                            + " where id in (" + cj.id + "," + pessoaEntity.Id + ")";
                        execultaQueryManual(sql);
                    }
                }
                MessageBox.Show("Pessoa editada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Membro/Pessoa", Validator.EDITAR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }

        public bool excluir(int id)
        {
            var query = from p in DB.pessoas where p.id == id select p;
            foreach (var pessoa in query)
            {
                DB.pessoas.DeleteOnSubmit(pessoa);
            }
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Pessoa excluída com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Validator.tratarErrosSql("Membro/Pessoa", Validator.EXCLUIR, ex.Message);
                DB = new db_entityDataContext();
                return false;
            }
        }
        public DataTable getPessoas()
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Tipo", typeof(String)),
                new DataColumn ("Nome", typeof(String)),
                new DataColumn("Data Nascimento", typeof(DateTime)),
                new DataColumn ("Tel. Principal", typeof(String)),
                new DataColumn ("Tel. Secundário", typeof(String)),

            });
            var query = from p in DB.pessoas
                        from b in DB.bairros
                        where p.id_bairro == b.id
                        orderby p.tipo descending,p.nome
                        select new { p.id, tipo=(p.tipo == PessoaEntity.MEMBRO ? "Membro":"Não-membro")
                        , p.nome, p.data_nascimento, p.telefone_principal, p.telefone_secundario};

            foreach (var p in query)
            {
                dados.Rows.Add(new Object[] {p.id, p.tipo, p.nome,((DateTime)p.data_nascimento).ToString("dd/MM/yyyy") 
                    , p.telefone_principal, p.telefone_secundario});
            }
            return dados;
        }
        public override Entity getEntityByIdentificador(int id)
        {
            PessoaEntity pessoa = new PessoaEntity();
            var query = from p in DB.pessoas
                        from b in DB.bairros
                        where p.id == id
                        where p.id_bairro == b.id
                        select new { p.id, p.nome, p.data_nascimento, id_bairro = b.id, bairro = b.nome, p.endereco, p.cep
                        , p.numero,p.estado_civil,p.sexo , p.telefone_principal, p.telefone_secundario, p.comentario
                        , p.tipo, p.id_pai, p.id_mae, mae = p.mae.nome, pai = p.pai.nome, p.id_conjuge, conjuge = p.conjuge.nome};
            foreach (var p in query)
            {
                pessoa.Tipo = p.tipo;
                pessoa.Id = p.id;
                pessoa.Nome = p.nome;
                pessoa.DataNascimento = ((DateTime)p.data_nascimento);
                pessoa.Sexo = char.Parse(p.sexo.ToString());
                pessoa.EstadoCivil = Int32.Parse(p.estado_civil.ToString());
                pessoa.IdBairro = p.id_bairro;
                pessoa.Bairro = p.bairro;
                pessoa.Endereco = p.endereco;
                pessoa.Numero = p.numero;
                pessoa.Cep = p.cep;
                pessoa.TelefonePrincipal = p.telefone_principal;
                pessoa.TelefoneSecundario = p.telefone_secundario;
                if (p.id_conjuge != null)
                {
                    pessoa.IdConjuge = Int32.Parse(p.id_conjuge.ToString());
                    pessoa.Conjuge = p.conjuge;
                }
                if (p.id_mae != null)
                {
                    pessoa.IdMae = Int32.Parse(p.id_mae.ToString());
                    pessoa.Mae = p.mae;
                }
                if (p.id_pai != null)
                {
                    pessoa.IdPai = Int32.Parse(p.id_pai.ToString());
                    pessoa.Pai = p.pai;
                }
                pessoa.Comentario = p.comentario;
            }
            return pessoa;
        }

        public override DataTable getSource(string search)
        {
            DataTable dados = new DataTable();
            dados.Columns.AddRange(new DataColumn[] {
                new DataColumn ("Código", typeof(Int32)),
                new DataColumn ("Nome", typeof(String)),
                new DataColumn ("Data Nascimento", typeof(String)),
            });
            if (search != null)
            {
                var query = from p in DB.pessoas
                            where p.nome.Contains(search)
                            orderby p.nome
                            select new { p.id, p.nome, p.data_nascimento };
                foreach (var p in query)
                {
                    dados.Rows.Add(new Object[] {p.id, p.nome, p.data_nascimento });
                }
            }
            return dados;
        }
    }
}
