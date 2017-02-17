using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBDSystem.Model;

namespace EBDSystem.BD
{
    class MaeDAO : DAO
    {
        public override Entity getEntityByIdentificador(int id)
        {
            PessoaEntity pessoa = new PessoaEntity();
            var query = from p in DB.pessoas
                        where p.id == id
                        where p.sexo == 'F'
                        select new
                        {
                            p.id,
                            p.nome,
                            p.data_nascimento
                        };
            foreach (var p in query)
            {
                pessoa.Id = p.id;
                pessoa.Nome = p.nome;
                pessoa.DataNascimento = ((DateTime)p.data_nascimento);
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
                            where p.sexo == 'F'
                            orderby p.nome
                            select new { p.id, p.nome, p.data_nascimento };
                foreach (var p in query)
                {
                    dados.Rows.Add(new Object[] { p.id, p.nome, ((DateTime)p.data_nascimento).ToString("dd/MM/yyyy") });
                }
            }
            return dados;
        }
    }
}
