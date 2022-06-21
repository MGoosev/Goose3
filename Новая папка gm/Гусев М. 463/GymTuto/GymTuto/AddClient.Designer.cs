namespace GymTuto
{
    partial class AddClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientSDGV
            // 
            this.ClientSDGV.AllowUserToAddRows = false;
            this.ClientSDGV.AllowUserToDeleteRows = false;
            this.ClientSDGV.AllowUserToResizeColumns = false;
            this.ClientSDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ClientSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientSDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClientSDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientSDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ClientSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientSDGV.ColumnHeadersHeight = 30;
            this.ClientSDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientSDGV.EnableHeadersVisualStyles = false;
            this.ClientSDGV.GridColor = System.Drawing.Color.Silver;
            this.ClientSDGV.Location = new System.Drawing.Point(321, 95);
            this.ClientSDGV.Name = "ClientSDGV";
            this.ClientSDGV.ReadOnly = true;
            this.ClientSDGV.RowHeadersVisible = false;
            this.ClientSDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientSDGV.RowTemplate.Height = 30;
            this.ClientSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientSDGV.ShowEditingIcon = false;
            this.ClientSDGV.Size = new System.Drawing.Size(424, 309);
            this.ClientSDGV.TabIndex = 59;
            this.ClientSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientSDGV.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.ClientSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ClientSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ClientSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientSDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ClientSDGV.ThemeStyle.ReadOnly = true;
            this.ClientSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.ClientSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientSDGV.ThemeStyle.RowsStyle.Height = 30;
            this.ClientSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.ClientSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClientSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientSDGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 61;
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
            this.NameTb.Location = new System.Drawing.Point(39, 120);
            this.NameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(253, 35);
            this.NameTb.TabIndex = 60;
            this.NameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "СПИСОК КЛИЕНТОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Crimson;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(358, 455);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 33);
            this.BackBtn.TabIndex = 64;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(106, 371);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 33);
            this.DeleteBtn.TabIndex = 67;
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
            this.ChangeBtn.Location = new System.Drawing.Point(168, 316);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(100, 33);
            this.ChangeBtn.TabIndex = 66;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Crimson;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(49, 316);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 33);
            this.AddBtn.TabIndex = 65;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 69;
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
            this.PhoneTb.Location = new System.Drawing.Point(39, 221);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(253, 35);
            this.PhoneTb.TabIndex = 68;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.ClientSDGV);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientSDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ClientSDGV;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
    }
}