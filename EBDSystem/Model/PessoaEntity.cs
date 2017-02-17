using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBDSystem.Model
{
    class PessoaEntity : Entity
    {
        public static int CADASTRO_SIMPLES = 1, MEMBRO = 2, OFICIAL_PROFESSOR = 3;
        public static int SOLTEIRO = 10, CASADO = 20, VIUVO = 30;
        private int id;
        private string nome;
        private int tipo;
        private int idBairro;
        private String bairro;
        private String endereco;
        private String numero;
        private String cep;
        private int idPai;
        private String pai;
        private int idMae;
        private String mae;
        private int idClasse;
        private String classe;
        private DateTime dataNascimento;
        private char sexo;
        private int estadoCivil;
        private String telefonePrincipal;
        private String telefoneSecundario;
        private String comentario;
        private int idConjuge;
        private String conjuge;

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

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public int IdBairro
        {
            get { return idBairro; }
            set { idBairro = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value.Trim(); }
        }

        public int IdPai
        {
            get { return idPai; }
            set { idPai = value; }
        }

        public String Pai
        {
            get { return pai; }
            set { pai = value; }
        }

        public int IdMae
        {
            get { return idMae; }
            set { idMae = value; }
        }

        public String Mae
        {
            get { return mae; }
            set { mae = value; }
        }

        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public String Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public String TelefonePrincipal
        {
            get { return telefonePrincipal; }
            set { telefonePrincipal = value; }
        }

        public String TelefoneSecundario
        {
            get { return telefoneSecundario; }
            set { telefoneSecundario = value; }
        }

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public String Numero
        {
            get { return numero; }
            set { numero = value.Trim(); }
        }

        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public int IdConjuge
        {
            get { return idConjuge; }
            set { idConjuge = value; }
        }

        public String Conjuge
        {
            get { return conjuge; }
            set { conjuge = value; }
        }

        public override string FieldSearch()
        {
            return nome;
        }
    }
}
