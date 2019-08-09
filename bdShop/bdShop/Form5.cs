using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdShop
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Спортивные_товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивные_товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.shopDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Спортивные_товары". При необходимости она может быть перемещена или удалена.
            this.спортивные_товарыTableAdapter.Fill(this.shopDataSet.Спортивные_товары);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < клиентыDataGridView.RowCount; i++)
            {
                клиентыDataGridView.Rows[i].Selected = false;
                for (int j = 1; j < клиентыDataGridView.ColumnCount; j++)
                    if (клиентыDataGridView.Rows[i].Cells[j].Value != null)
                        if (клиентыDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            клиентыDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < клиентыDataGridView.RowCount; i++)
            {
                клиентыDataGridView.Rows[i].Selected = false;
                for (int j = 2; j < клиентыDataGridView.ColumnCount; j++)
                    if (клиентыDataGridView.Rows[i].Cells[j].Value != null)
                        if (клиентыDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            клиентыDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
