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
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }

        private void Спортивные_товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивные_товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.shopDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Спортивные_товары". При необходимости она может быть перемещена или удалена.
            this.спортивные_товарыTableAdapter.Fill(this.shopDataSet.Спортивные_товары);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string a = "Наименование: " + наименованияTextBox.Text + "    Стоимость: " + стоимостьTextBox.Text;
            MessageBox.Show(a, " Чек ", MessageBoxButtons.OKCancel);
        }

        private void Тип_товараDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < тип_товараDataGridView.Rows.Count; i++)
            {
                if (тип_товараDataGridView.Rows[e.RowIndex].Cells[1].Value == null)
                { спортивные_товарыBindingSource.Filter = string.Empty; }
                else
                    спортивные_товарыBindingSource.Filter = string.Format("[Наименования] Like'" + тип_товараDataGridView.Rows[e.RowIndex].Cells[1].Value + "%'");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            


            for (int i = 0; i < спортивные_товарыDataGridView.RowCount; i++)
            {
                спортивные_товарыDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < спортивные_товарыDataGridView.ColumnCount; j++)
                    if (спортивные_товарыDataGridView.Rows[i].Cells[j].Value != null)
                        if (спортивные_товарыDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            спортивные_товарыDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < спортивные_товарыDataGridView.RowCount; i++)
            {
                спортивные_товарыDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < спортивные_товарыDataGridView.ColumnCount; j++)
                    if (спортивные_товарыDataGridView.Rows[i].Cells[j].Value != null)
                        if (спортивные_товарыDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            спортивные_товарыDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
