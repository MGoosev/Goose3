namespace GymTuto
{
    partial class ViewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            this.MemberSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchMember = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.AgeTb = new System.Windows.Forms.ComboBox();
            this.priceTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u1707856_gymdbDataSet = new GymTuto.u1707856_gymdbDataSet();
            this.label16 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u1707856_gymdbDataSet1 = new GymTuto.u1707856_gymdbDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTblTableAdapter = new GymTuto.u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter();
            this.bookTblTableAdapter = new GymTuto.u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberSDGV
            // 
            this.MemberSDGV.AllowUserToAddRows = false;
            this.MemberSDGV.AllowUserToDeleteRows = false;
            this.MemberSDGV.AllowUserToResizeColumns = false;
            this.MemberSDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MemberSDGV.BackgroundColor = System.Drawing.Color.White;
            this.MemberSDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MemberSDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MemberSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MemberSDGV.ColumnHeadersHeight = 30;
            this.MemberSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberSDGV.EnableHeadersVisualStyles = false;
            this.MemberSDGV.GridColor = System.Drawing.Color.Silver;
            this.MemberSDGV.Location = new System.Drawing.Point(303, 155);
            this.MemberSDGV.Name = "MemberSDGV";
            this.MemberSDGV.ReadOnly = true;
            this.MemberSDGV.RowHeadersVisible = false;
            this.MemberSDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MemberSDGV.RowTemplate.Height = 30;
            this.MemberSDGV.RowTemplate.ReadOnly = true;
            this.MemberSDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberSDGV.Size = new System.Drawing.Size(1044, 422);
            this.MemberSDGV.TabIndex = 47;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.MemberSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.MemberSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemberSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.MemberSDGV.ThemeStyle.ReadOnly = true;
            this.MemberSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.MemberSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemberSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MemberSDGV.ThemeStyle.RowsStyle.Height = 30;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MemberSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberSDGV_CellContentClick);
            // 
            // SearchMember
            // 
            this.SearchMember.BackColor = System.Drawing.Color.White;
            this.SearchMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchMember.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMember.ForeColor = System.Drawing.Color.Black;
            this.SearchMember.HintForeColor = System.Drawing.Color.Empty;
            this.SearchMember.HintText = "";
            this.SearchMember.isPassword = false;
            this.SearchMember.LineFocusedColor = System.Drawing.Color.Maroon;
            this.SearchMember.LineIdleColor = System.Drawing.Color.Crimson;
            this.SearchMember.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.SearchMember.LineThickness = 4;
            this.SearchMember.Location = new System.Drawing.Point(344, 85);
            this.SearchMember.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchMember.Name = "SearchMember";
            this.SearchMember.Size = new System.Drawing.Size(236, 33);
            this.SearchMember.TabIndex = 48;
            this.SearchMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchMember.OnValueChanged += new System.EventHandler(this.SearchMember_OnValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(578, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 49;
            this.button2.Text = "Найти";
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
            this.button1.Location = new System.Drawing.Point(701, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(667, 616);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 33);
            this.button4.TabIndex = 51;
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
            this.panel1.Size = new System.Drawing.Size(1368, 49);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "СПИСОК ДЕЙСТВУЮЩИХ АБОНЕМЕНТОВ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(303, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Crimson;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecreaseBtn.ForeColor = System.Drawing.Color.White;
            this.DecreaseBtn.Location = new System.Drawing.Point(1150, 85);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(197, 33);
            this.DecreaseBtn.TabIndex = 58;
            this.DecreaseBtn.Text = "Отметить посещение";
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // AgeTb
            // 
            this.AgeTb.DataSource = this.priceTblBindingSource;
            this.AgeTb.DisplayMember = "PTime";
            this.AgeTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeTb.FormattingEnabled = true;
            this.AgeTb.Location = new System.Drawing.Point(22, 437);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(252, 31);
            this.AgeTb.TabIndex = 66;
            // 
            // priceTblBindingSource
            // 
            this.priceTblBindingSource.DataMember = "PriceTbl";
            this.priceTblBindingSource.DataSource = this.u1707856_gymdbDataSet;
            // 
            // u1707856_gymdbDataSet
            // 
            this.u1707856_gymdbDataSet.DataSetName = "u1707856_gymdbDataSet";
            this.u1707856_gymdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(18, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 19);
            this.label16.TabIndex = 65;
            this.label16.Text = "Кол-во тренировок:";
            // 
            // GenderCb
            // 
            this.GenderCb.DataSource = this.bookTblBindingSource;
            this.GenderCb.DisplayMember = "BTitle";
            this.GenderCb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Location = new System.Drawing.Point(22, 303);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(252, 31);
            this.GenderCb.TabIndex = 64;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this.u1707856_gymdbDataSet1;
            // 
            // u1707856_gymdbDataSet1
            // 
            this.u1707856_gymdbDataSet1.DataSetName = "u1707856_gymdbDataSet";
            this.u1707856_gymdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Персональный тренер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Номер телефона:";
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.Color.White;
            this.PhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTb.ForeColor = System.Drawing.Color.Black;
            this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.HintText = "";
            this.PhoneTb.isPassword = false;
            this.PhoneTb.LineFocusedColor = System.Drawing.Color.Maroon;
            this.PhoneTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.PhoneTb.LineThickness = 4;
            this.PhoneTb.Location = new System.Drawing.Point(22, 231);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(252, 32);
            this.PhoneTb.TabIndex = 61;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "ФИО клиента:";
            // 
            // NameTb
            // 
            this.NameTb.BackColor = System.Drawing.Color.White;
            this.NameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTb.ForeColor = System.Drawing.Color.Black;
            this.NameTb.HintForeColor = System.Drawing.Color.Empty;
            this.NameTb.HintText = "";
            this.NameTb.isPassword = false;
            this.NameTb.LineFocusedColor = System.Drawing.Color.Maroon;
            this.NameTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.NameTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.NameTb.LineThickness = 4;
            this.NameTb.Location = new System.Drawing.Point(22, 167);
            this.NameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(252, 31);
            this.NameTb.TabIndex = 59;
            this.NameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Crimson;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(73, 524);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(139, 34);
            this.UpdateBtn.TabIndex = 67;
            this.UpdateBtn.Text = "Изменить";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TypeCb
            // 
            this.TypeCb.DataSource = this.priceTblBindingSource;
            this.TypeCb.DisplayMember = "PType";
            this.TypeCb.Enabled = false;
            this.TypeCb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Location = new System.Drawing.Point(22, 367);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(252, 31);
            this.TypeCb.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Тип тренировки:";
            // 
            // priceTblTableAdapter
            // 
            this.priceTblTableAdapter.ClearBeforeFill = true;
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(73, 576);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(139, 34);
            this.DeleteBtn.TabIndex = 74;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1368, 669);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.DecreaseBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchMember);
            this.Controls.Add(this.MemberSDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView MemberSDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchMember;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.ComboBox AgeTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTb;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.Label label2;
        private u1707856_gymdbDataSet u1707856_gymdbDataSet;
        private System.Windows.Forms.BindingSource priceTblBindingSource;
        private u1707856_gymdbDataSetTableAdapters.PriceTblTableAdapter priceTblTableAdapter;
        private u1707856_gymdbDataSet u1707856_gymdbDataSet1;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.Button DeleteBtn;
    }
}