namespace GymTuto
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.bookTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.u1707856_gymdbDataSet = new GymTuto.u1707856_gymdbDataSet();
            this.bookTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymDBDataSet = new GymTuto.GymDBDataSet();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTblTableAdapter = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.BookTblTableAdapter();
            this.Periode = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.AmountTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.priceTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.priceTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.priceTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AgeTb = new System.Windows.Forms.ComboBox();
            this.priceTblTableAdapter = new GymTuto._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.PriceTblTableAdapter();
            this.bookTblTableAdapter1 = new GymTuto.GymDBDataSetTableAdapters.BookTblTableAdapter();
            this.bookTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.priceTblTableAdapter1 = new GymTuto.GymDBDataSetTableAdapters.PriceTblTableAdapter();
            this.bookTblTableAdapter2 = new GymTuto.u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter();
            this.priceTblTableAdapter2 = new GymTuto.u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.ComboBox();
            this.clientTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTblTableAdapter = new GymTuto.u1707856_gymdbDataSetTableAdapters.ClientTblTableAdapter();
            this.PhoneTb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "ФИО клиента:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(391, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Кол-во тренировок:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Персональный тренер:";
            // 
            // GenderCb
            // 
            this.GenderCb.DataSource = this.bookTblBindingSource3;
            this.GenderCb.DisplayMember = "BTitle";
            this.GenderCb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Location = new System.Drawing.Point(54, 205);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(289, 31);
            this.GenderCb.TabIndex = 13;
            this.GenderCb.SelectedIndexChanged += new System.EventHandler(this.GenderCb_SelectedIndexChanged);
            // 
            // bookTblBindingSource3
            // 
            this.bookTblBindingSource3.DataMember = "BookTbl";
            this.bookTblBindingSource3.DataSource = this.u1707856_gymdbDataSet;
            // 
            // u1707856_gymdbDataSet
            // 
            this.u1707856_gymdbDataSet.DataSetName = "u1707856_gymdbDataSet";
            this.u1707856_gymdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTblBindingSource1
            // 
            this.bookTblBindingSource1.DataMember = "BookTbl";
            this.bookTblBindingSource1.DataSource = this.gymDBDataSet;
            // 
            // gymDBDataSet
            // 
            this.gymDBDataSet.DataSetName = "GymDBDataSet";
            this.gymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
            // 
            // _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet
            // 
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet.DataSetName = "_C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet";
            this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(337, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Сумма:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(931, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Дата добавления:";
            this.label9.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(336, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(273, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 32);
            this.button4.TabIndex = 22;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 51);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ОФОРМЛЕНИЕ АБОНЕМЕНТА";
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // Periode
            // 
            this.Periode.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Periode.Enabled = false;
            this.Periode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Periode.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periode.Location = new System.Drawing.Point(935, 290);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(129, 31);
            this.Periode.TabIndex = 38;
            this.Periode.Visible = false;
            this.Periode.ValueChanged += new System.EventHandler(this.Periode_ValueChanged);
            // 
            // AmountTb
            // 
            this.AmountTb.BackColor = System.Drawing.Color.White;
            this.AmountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AmountTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.priceTblBindingSource3, "PPrice", true));
            this.AmountTb.Enabled = false;
            this.AmountTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountTb.ForeColor = System.Drawing.Color.Black;
            this.AmountTb.HintForeColor = System.Drawing.Color.Empty;
            this.AmountTb.HintText = "";
            this.AmountTb.isPassword = false;
            this.AmountTb.LineFocusedColor = System.Drawing.Color.White;
            this.AmountTb.LineIdleColor = System.Drawing.Color.White;
            this.AmountTb.LineMouseHoverColor = System.Drawing.Color.White;
            this.AmountTb.LineThickness = 4;
            this.AmountTb.Location = new System.Drawing.Point(337, 289);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(154, 31);
            this.AmountTb.TabIndex = 41;
            this.AmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountTb.OnValueChanged += new System.EventHandler(this.AmountTb_OnValueChanged_1);
            // 
            // priceTblBindingSource3
            // 
            this.priceTblBindingSource3.DataMember = "PriceTbl";
            this.priceTblBindingSource3.DataSource = this.u1707856_gymdbDataSet;
            // 
            // priceTblBindingSource2
            // 
            this.priceTblBindingSource2.DataMember = "PriceTbl";
            this.priceTblBindingSource2.DataSource = this.gymDBDataSet;
            // 
            // priceTblBindingSource
            // 
            this.priceTblBindingSource.DataMember = "PriceTbl";
            this.priceTblBindingSource.DataSource = this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
            // 
            // priceTblBindingSource1
            // 
            this.priceTblBindingSource1.DataMember = "PriceTbl";
            this.priceTblBindingSource1.DataSource = this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
            // 
            // AgeTb
            // 
            this.AgeTb.DataSource = this.priceTblBindingSource3;
            this.AgeTb.DisplayMember = "PTime";
            this.AgeTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeTb.FormattingEnabled = true;
            this.AgeTb.Location = new System.Drawing.Point(391, 205);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(172, 31);
            this.AgeTb.TabIndex = 42;
            this.AgeTb.SelectedIndexChanged += new System.EventHandler(this.AgeTb_SelectedIndexChanged);
            // 
            // priceTblTableAdapter
            // 
            this.priceTblTableAdapter.ClearBeforeFill = true;
            // 
            // bookTblTableAdapter1
            // 
            this.bookTblTableAdapter1.ClearBeforeFill = true;
            // 
            // bookTblBindingSource2
            // 
            this.bookTblBindingSource2.DataMember = "BookTbl";
            this.bookTblBindingSource2.DataSource = this.gymDBDataSet;
            // 
            // priceTblTableAdapter1
            // 
            this.priceTblTableAdapter1.ClearBeforeFill = true;
            // 
            // bookTblTableAdapter2
            // 
            this.bookTblTableAdapter2.ClearBeforeFill = true;
            // 
            // priceTblTableAdapter2
            // 
            this.priceTblTableAdapter2.ClearBeforeFill = true;
            // 
            // TypeCb
            // 
            this.TypeCb.DataSource = this.priceTblBindingSource3;
            this.TypeCb.DisplayMember = "PType";
            this.TypeCb.Enabled = false;
            this.TypeCb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Location = new System.Drawing.Point(148, 289);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(150, 31);
            this.TypeCb.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(144, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Тип тренировки:";
            // 
            // NameTb
            // 
            this.NameTb.DataSource = this.clientTblBindingSource;
            this.NameTb.DisplayMember = "CName";
            this.NameTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTb.FormattingEnabled = true;
            this.NameTb.Location = new System.Drawing.Point(54, 113);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(289, 31);
            this.NameTb.TabIndex = 70;
            // 
            // clientTblBindingSource
            // 
            this.clientTblBindingSource.DataMember = "ClientTbl";
            this.clientTblBindingSource.DataSource = this.u1707856_gymdbDataSet;
            // 
            // clientTblTableAdapter
            // 
            this.clientTblTableAdapter.ClearBeforeFill = true;
            // 
            // PhoneTb
            // 
            this.PhoneTb.DataSource = this.clientTblBindingSource;
            this.PhoneTb.DisplayMember = "CPhone";
            this.PhoneTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTb.FormattingEnabled = true;
            this.PhoneTb.Location = new System.Drawing.Point(391, 113);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(172, 31);
            this.PhoneTb.TabIndex = 71;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(624, 470);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.DateTimePicker Periode;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AmountTb;
        private System.Windows.Forms.ComboBox AgeTb;
        private System.Windows.Forms.BindingSource priceTblBindingSource;
        private _C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter;
        private System.Windows.Forms.BindingSource priceTblBindingSource1;
        private GymDBDataSet gymDBDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource1;
        private GymDBDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter1;
        private System.Windows.Forms.BindingSource bookTblBindingSource2;
        private System.Windows.Forms.BindingSource priceTblBindingSource2;
        private GymDBDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter1;
        private u1707856_gymdbDataSet u1707856_gymdbDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource3;
        private u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter2;
        private System.Windows.Forms.BindingSource priceTblBindingSource3;
        private u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter2;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NameTb;
        private System.Windows.Forms.BindingSource clientTblBindingSource;
        private u1707856_gymdbDataSetTableAdapters.ClientTblTableAdapter clientTblTableAdapter;
        private System.Windows.Forms.ComboBox PhoneTb;
    }
}