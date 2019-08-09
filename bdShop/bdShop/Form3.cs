using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace bdShop
{
    public partial class Form3 : Form
    {
        public static string connectString = (@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Shop.mdb");
        private OleDbConnection myConnection;
        public Form3()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            InitializeComponent();
        }

       

        private void ИдентификацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.идентификацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

       

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectString))
            {
                string commText = "insert into Идентификация (Логин, Пароль) values (?,?)"; //в таблице Table1 3 поля: field1, field2, field3
                OleDbCommand comm = new OleDbCommand(commText, conn);

                comm.Parameters.AddWithValue("@Логин", textBox1.Text);
                comm.Parameters.AddWithValue("@Пароль", textBox2.Text);
                conn.Open();

                try
                {
                    comm.ExecuteNonQuery();
                    
                }
                catch
                {
                    MessageBox.Show("Добавить не удалось!");
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 nd = new Form1();
            nd.Show();
            this.Hide();
        }
    }
}
