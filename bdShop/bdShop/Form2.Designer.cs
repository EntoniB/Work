namespace bdShop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label наименованияLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label типLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.shopDataSet = new bdShop.ShopDataSet();
            this.спортивные_товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортивные_товарыTableAdapter = new bdShop.ShopDataSetTableAdapters.Спортивные_товарыTableAdapter();
            this.tableAdapterManager = new bdShop.ShopDataSetTableAdapters.TableAdapterManager();
            this.тип_товараTableAdapter = new bdShop.ShopDataSetTableAdapters.Тип_товараTableAdapter();
            this.спортивные_товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.спортивные_товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.спортивные_товарыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованияTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.тип_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.тип_товараDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            наименованияLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingNavigator)).BeginInit();
            this.спортивные_товарыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованияLabel
            // 
            наименованияLabel.AutoSize = true;
            наименованияLabel.Location = new System.Drawing.Point(7, 277);
            наименованияLabel.Name = "наименованияLabel";
            наименованияLabel.Size = new System.Drawing.Size(86, 13);
            наименованияLabel.TabIndex = 2;
            наименованияLabel.Text = "Наименования:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(5, 313);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 4;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(8, 351);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(29, 13);
            типLabel.TabIndex = 6;
            типLabel.Text = "Тип:";
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спортивные_товарыBindingSource
            // 
            this.спортивные_товарыBindingSource.DataMember = "Спортивные товары";
            this.спортивные_товарыBindingSource.DataSource = this.shopDataSet;
            // 
            // спортивные_товарыTableAdapter
            // 
            this.спортивные_товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = bdShop.ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ИдентификацияTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Спортивные_товарыTableAdapter = this.спортивные_товарыTableAdapter;
            this.tableAdapterManager.Тип_товараTableAdapter = this.тип_товараTableAdapter;
            // 
            // тип_товараTableAdapter
            // 
            this.тип_товараTableAdapter.ClearBeforeFill = true;
            // 
            // спортивные_товарыBindingNavigator
            // 
            this.спортивные_товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.спортивные_товарыBindingNavigator.BindingSource = this.спортивные_товарыBindingSource;
            this.спортивные_товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.спортивные_товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.спортивные_товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.спортивные_товарыBindingNavigatorSaveItem});
            this.спортивные_товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.спортивные_товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.спортивные_товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.спортивные_товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.спортивные_товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.спортивные_товарыBindingNavigator.Name = "спортивные_товарыBindingNavigator";
            this.спортивные_товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.спортивные_товарыBindingNavigator.Size = new System.Drawing.Size(712, 25);
            this.спортивные_товарыBindingNavigator.TabIndex = 0;
            this.спортивные_товарыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // спортивные_товарыBindingNavigatorSaveItem
            // 
            this.спортивные_товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.спортивные_товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("спортивные_товарыBindingNavigatorSaveItem.Image")));
            this.спортивные_товарыBindingNavigatorSaveItem.Name = "спортивные_товарыBindingNavigatorSaveItem";
            this.спортивные_товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.спортивные_товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.спортивные_товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.Спортивные_товарыBindingNavigatorSaveItem_Click);
            // 
            // спортивные_товарыDataGridView
            // 
            this.спортивные_товарыDataGridView.AutoGenerateColumns = false;
            this.спортивные_товарыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.спортивные_товарыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.спортивные_товарыDataGridView.DataSource = this.спортивные_товарыBindingSource;
            this.спортивные_товарыDataGridView.Location = new System.Drawing.Point(208, 28);
            this.спортивные_товарыDataGridView.Name = "спортивные_товарыDataGridView";
            this.спортивные_товарыDataGridView.Size = new System.Drawing.Size(246, 220);
            this.спортивные_товарыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_тип";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_спортивных_товаров";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_спортивных_товаров";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименования";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // наименованияTextBox
            // 
            this.наименованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивные_товарыBindingSource, "Наименования", true));
            this.наименованияTextBox.Location = new System.Drawing.Point(99, 274);
            this.наименованияTextBox.Name = "наименованияTextBox";
            this.наименованияTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованияTextBox.TabIndex = 3;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивные_товарыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(76, 310);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 5;
            // 
            // тип_товараBindingSource
            // 
            this.тип_товараBindingSource.DataMember = "Тип товара";
            this.тип_товараBindingSource.DataSource = this.shopDataSet;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_товараBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(43, 348);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(100, 20);
            this.типTextBox.TabIndex = 7;
            // 
            // тип_товараDataGridView
            // 
            this.тип_товараDataGridView.AutoGenerateColumns = false;
            this.тип_товараDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тип_товараDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.тип_товараDataGridView.DataSource = this.тип_товараBindingSource;
            this.тип_товараDataGridView.Location = new System.Drawing.Point(10, 28);
            this.тип_товараDataGridView.Name = "тип_товараDataGridView";
            this.тип_товараDataGridView.Size = new System.Drawing.Size(153, 220);
            this.тип_товараDataGridView.TabIndex = 8;
            this.тип_товараDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Тип_товараDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_тип";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_тип";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(611, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Чек";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(478, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Выборка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Выборка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выбор по наименованию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выборка по стоимости";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.тип_товараDataGridView);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(наименованияLabel);
            this.Controls.Add(this.наименованияTextBox);
            this.Controls.Add(this.спортивные_товарыDataGridView);
            this.Controls.Add(this.спортивные_товарыBindingNavigator);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingNavigator)).EndInit();
            this.спортивные_товарыBindingNavigator.ResumeLayout(false);
            this.спортивные_товарыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource спортивные_товарыBindingSource;
        private ShopDataSetTableAdapters.Спортивные_товарыTableAdapter спортивные_товарыTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator спортивные_товарыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton спортивные_товарыBindingNavigatorSaveItem;
        private ShopDataSetTableAdapters.Тип_товараTableAdapter тип_товараTableAdapter;
        private System.Windows.Forms.DataGridView спортивные_товарыDataGridView;
        private System.Windows.Forms.TextBox наименованияTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.BindingSource тип_товараBindingSource;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.DataGridView тип_товараDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}