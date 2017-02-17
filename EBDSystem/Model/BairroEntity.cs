using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBDSystem.Model
{
    class BairroEntity:Entity
    {
        private int id;
        private int idCidade;
        private int idEstado;
        private String cidade;
        private String nome;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdCidade
        {
            get { return idCidade; }
            set { idCidade = value; }
        }

        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        public String NomeCidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value.Trim(); }
        }

        public override string FieldSearch()
        {
            return nome;
        }
    }
}
