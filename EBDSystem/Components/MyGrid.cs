using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBDSystem.Components
{
    public class MyGrid:DataGridView
    {
        private int identificador;

        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public int getCurrentIdentificador()
        {
            if (this.CurrentRow != null)
                return Int32.Parse(this.CurrentRow.Cells[identificador].Value.ToString());
            else
                return -1;
        }
    }
}
