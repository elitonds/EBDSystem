using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EBDSystem.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EBDSystem.BD
{
    public abstract class DAO
    {
        private db_entityDataContext db = new db_entityDataContext();
        protected DataSet ds;
        protected SqlCommand command;
        protected SqlCommandBuilder commandBuilder;
        protected DataSet dataSet;
        protected SqlDataAdapter adapter;

        public abstract DataTable getSource(String search);
        public abstract Entity getEntityByIdentificador(int id);

        public db_entityDataContext DB
        {
            get { return db; }
            set { db = value; }
        }

        public virtual bool execultaQueryManual(String sql)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(DB.Connection.ConnectionString);
            try
            {
                command = new SqlCommand(sql, conn);
                conn.Open();
                int num = command.ExecuteNonQuery();
                if (num > 0)
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Erro", "Problemas na transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Problemas na transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("" + sql, "Sintaxe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
