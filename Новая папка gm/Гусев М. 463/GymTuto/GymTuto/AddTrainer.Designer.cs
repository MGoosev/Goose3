namespace GymTuto
{
    partial class AddTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrainer));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.TrainerSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bookTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.u1707856_gymdbDataSet = new GymTuto.u1707856_gymdbDataSet();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDBDataSet = new GymTuto.GymDBDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTblTableAdapter = new GymTuto.GymDBDataSetTableAdapters.BookTblTableAdapter();
            this.bookTblTableAdapter1 = new GymTuto.u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerSDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(117, 353);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(106, 33);
            this.DeleteBtn.TabIndex = 60;
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
            this.ChangeBtn.Location = new System.Drawing.Point(180, 297);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(106, 33);
            this.ChangeBtn.TabIndex = 59;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // TrainerSDGV
            // 
            this.TrainerSDGV.AllowUserToAddRows = false;
            this.TrainerSDGV.AllowUserToDeleteRows = false;
            this.TrainerSDGV.AllowUserToResizeColumns = false;
            this.TrainerSDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TrainerSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrainerSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrainerSDGV.BackgroundColor = System.Drawing.Color.White;
            this.TrainerSDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrainerSDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TrainerSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrainerSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TrainerSDGV.ColumnHeadersHeight = 30;
            this.TrainerSDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrainerSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrainerSDGV.EnableHeadersVisualStyles = false;
            this.TrainerSDGV.GridColor = System.Drawing.Color.Silver;
            this.TrainerSDGV.Location = new System.Drawing.Point(328, 92);
            this.TrainerSDGV.Name = "TrainerSDGV";
            this.TrainerSDGV.ReadOnly = true;
            this.TrainerSDGV.RowHeadersVisible = false;
            this.TrainerSDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TrainerSDGV.RowTemplate.Height = 30;
            this.TrainerSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrainerSDGV.ShowEditingIcon = false;
            this.TrainerSDGV.Size = new System.Drawing.Size(448, 294);
            this.TrainerSDGV.TabIndex = 58;
            this.TrainerSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainerSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TrainerSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TrainerSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TrainerSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TrainerSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TrainerSDGV.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.TrainerSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.TrainerSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TrainerSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainerSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TrainerSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TrainerSDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.TrainerSDGV.ThemeStyle.ReadOnly = true;
            this.TrainerSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainerSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.TrainerSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainerSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.TrainerSDGV.ThemeStyle.RowsStyle.Height = 30;
            this.TrainerSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.TrainerSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TrainerSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainerSDGV_CellContentClick);
            // 
            // bookTblBindingSource1
            // 
            this.bookTblBindingSource1.DataMember = "BookTbl";
            this.bookTblBindingSource1.DataSource = this.u1707856_gymdbDataSet;
            // 
            // u1707856_gymdbDataSet
            // 
            this.u1707856_gymdbDataSet.DataSetName = "u1707856_gymdbDataSet";
            this.u1707856_gymdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this.gymDBDataSet;
            // 
            // gymDBDataSet
            // 
            this.gymDBDataSet.DataSetName = "GymDBDataSet";
            this.gymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(350, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 33);
            this.button4.TabIndex = 57;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Crimson;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(51, 297);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(106, 33);
            this.AddBtn.TabIndex = 55;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "ФИО тренера:";
            // 
            // TitleTb
            // 
            this.TitleTb.BackColor = System.Drawing.Color.White;
            this.TitleTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TitleTb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTb.ForeColor = System.Drawing.Color.Black;
            this.TitleTb.HintForeColor = System.Drawing.Color.Empty;
            this.TitleTb.HintText = "";
            this.TitleTb.isPassword = false;
            this.TitleTb.LineFocusedColor = System.Drawing.Color.Maroon;
            this.TitleTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.TitleTb.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.TitleTb.LineThickness = 4;
            this.TitleTb.Location = new System.Drawing.Point(44, 116);
            this.TitleTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.Size = new System.Drawing.Size(253, 35);
            this.TitleTb.TabIndex = 53;
            this.TitleTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 50);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ТРЕНЕРСКИЙ СОСТАВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // bookTblTableAdapter1
            // 
            this.bookTblTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 71;
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
            this.PhoneTb.Location = new System.Drawing.Point(44, 204);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(253, 35);
            this.PhoneTb.TabIndex = 70;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.TrainerSDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleTb);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainerSDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u1707856_gymdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private Guna.UI2.WinForms.Guna2DataGridView TrainerSDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TitleTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private GymDBDataSet gymDBDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private GymDBDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private u1707856_gymdbDataSet u1707856_gymdbDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource1;
        private u1707856_gymdbDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
    }
}