using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;

namespace EBDSystem.BD
{
    class ConjugeDAO : DAO
    {
        public override Entity getEntityByIdentificador(int id)
        {
            PessoaEntity pessoa = new PessoaEntity();
            var query = from p in DB.pessoas
                        from b in DB.bairros
                        where p.id == id
                        where p.id_bairro == b.id
                        select new
                        {
                            p.id,
                            p.nome,
                            p.data_nascimento,
                            id_bairro = b.id,
                            bairro = b.nome,
                            p.endereco,
                            p.cep
                        ,
                            p.numero,
                            p.estado_civil,
                            p.sexo,
                            p.telefone_principal,
                            p.telefone_secundario,
                            p.comentario
                        ,
                            p.tipo,
                            p.id_pai,
                            p.id_mae,
                            mae = p.mae.nome,
                            pai = p.pai.nome,
                            conjuge = p.conjuge.nome
                        };
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
                pessoa.Conjuge = p.conjuge;
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
                            where p.estado_civil == PessoaEntity.SOLTEIRO
                            orderby p.nome
                            select new { p.id, p.nome, p.data_nascimento };
                foreach (var p in query)
                {
                    dados.Rows.Add(new Object[] { p.id, p.nome, p.data_nascimento });
                }
            }
            return dados;
        }
    }
}
