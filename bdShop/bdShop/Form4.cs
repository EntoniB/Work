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
    public partial class Form4 : Form
    {
        public static string connectString = (@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Shop.mdb");
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectString))
            {
                string commText = "insert into Клиенты (ФИО,Адресс,Телефон,№карты,ID_Клиента) values (?,?,?,?,1)"; //в таблице Table1 3 поля: field1, field2, field3
                OleDbCommand comm = new OleDbCommand(commText, conn);

                comm.Parameters.AddWithValue("@ФИО", textBox1.Text);
                comm.Parameters.AddWithValue("@Адресс", textBox2.Text);
                comm.Parameters.AddWithValue("@Телефон", textBox3.Text);
                comm.Parameters.AddWithValue("@№карты", textBox4.Text);
                conn.Open();

                
                    comm.ExecuteNonQuery();


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
