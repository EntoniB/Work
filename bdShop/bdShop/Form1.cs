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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Shop.mdb");
            OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT(*) From Идентификация where Логин = '" + textBox1.Text + "'and Пароль = '" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                Form2 frm4 = new Form2();
                frm4.Show();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Shop.mdb");
            OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT(*) From Идентификация where Логин = '" + textBox1.Text + "'and Пароль = '" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                Form5 fr5 = new Form5();
                fr5.Show();
               

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!!!");
            }
        }
    }
}
