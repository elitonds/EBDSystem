using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBDSystem.Util
{
    class Validator
    {
        public static int INSERIR = 1, EDITAR = 2, EXCLUIR = 3;
        public static bool validaCampos(Object [] campos)
        {
            foreach(Object o in campos)
            {
                if(o.GetType() == typeof(TextBox))
                {
                    TextBox text = ((TextBox)o);
                    if (text.Text.Trim() == String.Empty)
                    {
                        MessageBox.Show("O campo "+text.AccessibleName+" não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }else if(o.GetType() == typeof(ComboBox))
                {
                    ComboBox combo = ((ComboBox)o);
                    if (combo.Text.Trim() == String.Empty || combo.Text.Trim() == "Selecione")
                    {
                        MessageBox.Show("O campo " + combo.AccessibleName + " não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else if (o.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker date = ((DateTimePicker)o);
                    if(date.Value == null)
                    {
                        MessageBox.Show("O campo " + date.AccessibleName + " não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        public static void tratarErrosSql(String tabela, int operacao, String message)
        {
            Dictionary<int, String> acoes = new Dictionary<int, string>();
            acoes.Add(INSERIR, "inserir");
            acoes.Add(EDITAR, "editar");
            acoes.Add(EXCLUIR, "excluir");
            if (message.ToUpper().Contains("UNIQUE KEY"))
            {
                MessageBox.Show("Erro ao tentar " + acoes[operacao] + " registro de " + tabela + "\n"+"Registro já existe!"
                    , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message.ToUpper().Contains("REFERENCE"))
            {
                MessageBox.Show("Erro ao tentar " + acoes[operacao] + " registro de " + tabela + "\n"+"Registro está sendo usado!"
                    , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                MessageBox.Show("Erro no Banco de Dados não tratado \n" + message
                    , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
