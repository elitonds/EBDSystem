using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBDSystem.Model
{
    class ClasseEntity : Entity
    {
        private int id;
        private String nome;
        private Dictionary<int, PessoaEntity> professores;
        public ClasseEntity()
        {
            professores = new Dictionary<int, PessoaEntity>();
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value.Trim(); }
        }

        public Dictionary<int, PessoaEntity> Professores
        {
            get { return professores; }
            set { professores = value; }
        }
        public override string FieldSearch()
        {
            return nome;
        }
    }
}
