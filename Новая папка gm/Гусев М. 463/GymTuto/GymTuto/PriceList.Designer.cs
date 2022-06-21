namespace GymTuto
{
    partial class PriceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PListSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.priceTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.u1707856_gymdbDataSet = new GymTuto.u1707856_gymdbDataSet();
            this.priceTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bookTblTableAdapter = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.BookTblTableAdapter();
            this.priceTblTableAdapter = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.PriceTblTableAdapter();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.TimeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.priceTblTableAdapter1 = new GymTuto.u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.priceTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PListSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Цена:";
            // 
            // PriceTb
            // 
            this.PriceTb.BackColor = System.Drawing.Color.White;
            this.PriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTb.ForeColor = System.Drawing.Color.Black;
            this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTb.HintText = "";
            this.PriceTb.isPassword = false;
            this.PriceTb.LineFocusedColor = System.Drawing.Color.Maroon;
            this.PriceTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.PriceTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.PriceTb.LineThickness = 4;
            this.PriceTb.Location = new System.Drawing.Point(28, 296);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(224, 37);
            this.PriceTb.TabIndex = 34;
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Количество тренировок:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(73, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 34);
            this.button3.TabIndex = 44;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(73, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 43;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(341, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PListSDGV
            // 
            this.PListSDGV.AllowUserToAddRows = false;
            this.PListSDGV.AllowUserToDeleteRows = false;
            this.PListSDGV.AllowUserToResizeColumns = false;
            this.PListSDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PListSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PListSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PListSDGV.BackgroundColor = System.Drawing.Color.White;
            this.PListSDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PListSDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.PListSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PListSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PListSDGV.ColumnHeadersHeight = 30;
            this.PListSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PListSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PListSDGV.EnableHeadersVisualStyles = false;
            this.PListSDGV.GridColor = System.Drawing.Color.Silver;
            this.PListSDGV.Location = new System.Drawing.Point(282, 98);
            this.PListSDGV.Name = "PListSDGV";
            this.PListSDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PListSDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PListSDGV.RowHeadersVisible = false;
            this.PListSDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PListSDGV.RowTemplate.Height = 30;
            this.PListSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PListSDGV.Size = new System.Drawing.Size(496, 383);
            this.PListSDGV.TabIndex = 52;
            this.PListSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PListSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PListSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PListSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PListSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PListSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PListSDGV.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.PListSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.PListSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PListSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PListSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PListSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PListSDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PListSDGV.ThemeStyle.ReadOnly = true;
            this.PListSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PListSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.PListSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PListSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PListSDGV.ThemeStyle.RowsStyle.Height = 30;
            this.PListSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.PListSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PListSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PListSDGV_CellContentClick);
            // 
            // priceTblBindingSource1
            // 
            this.priceTblBindingSource1.DataMember = "PriceTbl";
            this.priceTblBindingSource1.DataSource = this.u1707856_gymdbDataSet;
            // 
            // u1707856_gymdbDataSet
            // 
            this.u1707856_gymdbDataSet.DataSetName = "u1707856_gymdbDataSet";
            this.u1707856_gymdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceTblBindingSource
            // 
            this.priceTblBindingSource.DataMember = "PriceTbl";
            this.priceTblBindingSource.DataSource = this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
            // 
            // _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet
            // 
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet.DataSetName = "_C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet";
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 52);
            this.panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ИЗМЕНИТЬ ПРАЙС-ЛИСТ";
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // priceTblTableAdapter
            // 
            this.priceTblTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(73, 477);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(126, 34);
            this.DeleteBtn.TabIndex = 62;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.Crimson;
            this.ChangeBtn.FlatAppearance.BorderSize = 0;
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeBtn.Location = new System.Drawing.Point(73, 424);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(126, 34);
            this.ChangeBtn.TabIndex = 61;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // TimeTb
            // 
            this.TimeTb.BackColor = System.Drawing.Color.White;
            this.TimeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTb.ForeColor = System.Drawing.Color.Black;
            this.TimeTb.HintForeColor = System.Drawing.Color.Empty;
            this.TimeTb.HintText = "";
            this.TimeTb.isPassword = false;
            this.TimeTb.LineFocusedColor = System.Drawing.Color.Maroon;
            this.TimeTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.TimeTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.TimeTb.LineThickness = 4;
            this.TimeTb.Location = new System.Drawing.Point(26, 122);
            this.TimeTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(224, 37);
            this.TimeTb.TabIndex = 64;
            this.TimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // priceTblTableAdapter1
            // 
            this.priceTblTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Тип тренировки:";
            // 
            // TypeCb
            // 
            this.TypeCb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Items.AddRange(new object[] {
            "Одиночная",
            "Персональная"});
            this.TypeCb.Location = new System.Drawing.Point(28, 216);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(220, 31);
            this.TypeCb.TabIndex = 67;
            // 
            // priceTblBindingSource2
            // 
            this.priceTblBindingSource2.DataMember = "PriceTbl";
            this.priceTblBindingSource2.DataSource = this.u1707856_gymdbDataSet;
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(810, 592);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PListSDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PListSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView PListSDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.BindingSource priceTblBindingSource;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TimeTb;
        private u1707856_gymdbDataSet u1707856_gymdbDataSet;
        private System.Windows.Forms.BindingSource priceTblBindingSource1;
        private u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.BindingSource priceTblBindingSource2;
    }
}