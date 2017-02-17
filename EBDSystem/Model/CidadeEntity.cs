using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.EntityClient;
using System.Text;
using System.Threading.Tasks;

namespace EBDSystem.Model
{
    
    class CidadeEntity:Entity
    {
        private int id;
        private int idEstado;
        private String uf;
        private String nome;

        public  int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value.Trim(); }
        }
        public override string FieldSearch()
        {
            return nome + "-" + uf;
        }
    }
}
