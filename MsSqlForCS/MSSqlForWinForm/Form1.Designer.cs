namespace MSSqlForWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DateField = new System.Windows.Forms.TextBox();
            this.FromField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxRow = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SelectButtonToSQLDRider = new System.Windows.Forms.Button();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityPerUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DateField);
            this.tabPage1.Controls.Add(this.FromField);
            this.tabPage1.Controls.Add(this.PhoneField);
            this.tabPage1.Controls.Add(this.EmailField);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.SurnameField);
            this.tabPage1.Controls.Add(this.InsertButton);
            this.tabPage1.Controls.Add(this.NameField);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " INSERT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DateField
            // 
            this.DateField.Location = new System.Drawing.Point(237, 27);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(100, 22);
            this.DateField.TabIndex = 7;
            // 
            // FromField
            // 
            this.FromField.Location = new System.Drawing.Point(343, 27);
            this.FromField.Name = "FromField";
            this.FromField.Size = new System.Drawing.Size(100, 22);
            this.FromField.TabIndex = 6;
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(449, 26);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(100, 22);
            this.PhoneField.TabIndex = 5;
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(555, 26);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(100, 22);
            this.EmailField.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(354, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(131, 27);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(100, 22);
            this.SurnameField.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(661, 26);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(123, 23);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(25, 26);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 22);
            this.NameField.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SELECT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SelectButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxRow, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(3, 313);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(131, 28);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "SELECT";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // TextBoxRow
            // 
            this.TextBoxRow.Location = new System.Drawing.Point(3, 347);
            this.TextBoxRow.Name = "TextBoxRow";
            this.TextBoxRow.Size = new System.Drawing.Size(780, 22);
            this.TextBoxRow.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SqlDataRider";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SelectButtonToSQLDRider, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 421);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.QuantityPerUnit,
            this.UnitPrice});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 372);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SelectButtonToSQLDRider
            // 
            this.SelectButtonToSQLDRider.Location = new System.Drawing.Point(3, 381);
            this.SelectButtonToSQLDRider.Name = "SelectButtonToSQLDRider";
            this.SelectButtonToSQLDRider.Size = new System.Drawing.Size(378, 23);
            this.SelectButtonToSQLDRider.TabIndex = 1;
            this.SelectButtonToSQLDRider.Text = "SELECT";
            this.SelectButtonToSQLDRider.UseVisualStyleBackColor = true;
            this.SelectButtonToSQLDRider.Click += new System.EventHandler(this.SelectButtonToSQLDRider_Click);
            // 
            // ProductName
            // 
            this.ProductName.Text = "ProductName";
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "UnitPrice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DateField;
        private System.Windows.Forms.TextBox FromField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBoxRow;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SelectButtonToSQLDRider;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader QuantityPerUnit;
        private System.Windows.Forms.ColumnHeader UnitPrice;
    }
}

