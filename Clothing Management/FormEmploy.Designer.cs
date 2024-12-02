namespace Clothing_Management
{
    partial class FormEmploy
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
            this.grView_hienthi7 = new System.Windows.Forms.DataGridView();
            this.rad_maleEmp = new System.Windows.Forms.RadioButton();
            this.txtB_dateEmp = new System.Windows.Forms.TextBox();
            this.rad_femaEmp = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_exitEmp = new System.Windows.Forms.Button();
            this.btn_deleEmp = new System.Windows.Forms.Button();
            this.btn_updateEmp = new System.Windows.Forms.Button();
            this.txtB_phoneEmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB_emailEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_nameEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_idEmployee = new System.Windows.Forms.TextBox();
            this.btn_addEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grView_hienthi7
            // 
            this.grView_hienthi7.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grView_hienthi7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grView_hienthi7.Location = new System.Drawing.Point(1, 340);
            this.grView_hienthi7.Name = "grView_hienthi7";
            this.grView_hienthi7.RowHeadersWidth = 51;
            this.grView_hienthi7.RowTemplate.Height = 24;
            this.grView_hienthi7.Size = new System.Drawing.Size(978, 226);
            this.grView_hienthi7.TabIndex = 51;
            this.grView_hienthi7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grView_hienthi7_CellContentClick);
            // 
            // rad_maleEmp
            // 
            this.rad_maleEmp.AutoSize = true;
            this.rad_maleEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_maleEmp.Location = new System.Drawing.Point(401, 223);
            this.rad_maleEmp.Name = "rad_maleEmp";
            this.rad_maleEmp.Size = new System.Drawing.Size(76, 24);
            this.rad_maleEmp.TabIndex = 45;
            this.rad_maleEmp.TabStop = true;
            this.rad_maleEmp.Text = "MALE";
            this.rad_maleEmp.UseVisualStyleBackColor = true;
            // 
            // txtB_dateEmp
            // 
            this.txtB_dateEmp.Location = new System.Drawing.Point(712, 191);
            this.txtB_dateEmp.Name = "txtB_dateEmp";
            this.txtB_dateEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_dateEmp.TabIndex = 43;
            // 
            // rad_femaEmp
            // 
            this.rad_femaEmp.AutoSize = true;
            this.rad_femaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_femaEmp.Location = new System.Drawing.Point(217, 221);
            this.rad_femaEmp.Name = "rad_femaEmp";
            this.rad_femaEmp.Size = new System.Drawing.Size(97, 24);
            this.rad_femaEmp.TabIndex = 44;
            this.rad_femaEmp.TabStop = true;
            this.rad_femaEmp.Text = "FEMALE";
            this.rad_femaEmp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Date:";
            // 
            // btn_exitEmp
            // 
            this.btn_exitEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitEmp.Location = new System.Drawing.Point(813, 302);
            this.btn_exitEmp.Name = "btn_exitEmp";
            this.btn_exitEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_exitEmp.TabIndex = 50;
            this.btn_exitEmp.Text = "EXIT";
            this.btn_exitEmp.UseVisualStyleBackColor = false;
            this.btn_exitEmp.Click += new System.EventHandler(this.btn_exitEmp_Click);
            // 
            // btn_deleEmp
            // 
            this.btn_deleEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleEmp.Location = new System.Drawing.Point(813, 245);
            this.btn_deleEmp.Name = "btn_deleEmp";
            this.btn_deleEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_deleEmp.TabIndex = 48;
            this.btn_deleEmp.Text = "DELETE";
            this.btn_deleEmp.UseVisualStyleBackColor = false;
            this.btn_deleEmp.Click += new System.EventHandler(this.btn_deleEmp_Click);
            // 
            // btn_updateEmp
            // 
            this.btn_updateEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_updateEmp.Location = new System.Drawing.Point(634, 302);
            this.btn_updateEmp.Name = "btn_updateEmp";
            this.btn_updateEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_updateEmp.TabIndex = 47;
            this.btn_updateEmp.Text = "UPDATE";
            this.btn_updateEmp.UseVisualStyleBackColor = false;
            this.btn_updateEmp.Click += new System.EventHandler(this.btn_updateEmp_Click);
            // 
            // txtB_phoneEmp
            // 
            this.txtB_phoneEmp.Location = new System.Drawing.Point(712, 142);
            this.txtB_phoneEmp.Name = "txtB_phoneEmp";
            this.txtB_phoneEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_phoneEmp.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Phone: ";
            // 
            // txtB_emailEmp
            // 
            this.txtB_emailEmp.Location = new System.Drawing.Point(712, 82);
            this.txtB_emailEmp.Name = "txtB_emailEmp";
            this.txtB_emailEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_emailEmp.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gender:";
            // 
            // txtB_nameEmployee
            // 
            this.txtB_nameEmployee.Location = new System.Drawing.Point(217, 165);
            this.txtB_nameEmployee.Name = "txtB_nameEmployee";
            this.txtB_nameEmployee.Size = new System.Drawing.Size(175, 22);
            this.txtB_nameEmployee.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name Employee:";
            // 
            // txtB_idEmployee
            // 
            this.txtB_idEmployee.Location = new System.Drawing.Point(217, 95);
            this.txtB_idEmployee.Name = "txtB_idEmployee";
            this.txtB_idEmployee.Size = new System.Drawing.Size(175, 22);
            this.txtB_idEmployee.TabIndex = 35;
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addEmp.Location = new System.Drawing.Point(634, 245);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_addEmp.TabIndex = 46;
            this.btn_addEmp.Text = "ADD";
            this.btn_addEmp.UseVisualStyleBackColor = false;
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Employee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Get Employee Data";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(978, 65);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // FormEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 559);
            this.Controls.Add(this.grView_hienthi7);
            this.Controls.Add(this.rad_maleEmp);
            this.Controls.Add(this.txtB_dateEmp);
            this.Controls.Add(this.rad_femaEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_exitEmp);
            this.Controls.Add(this.btn_deleEmp);
            this.Controls.Add(this.btn_updateEmp);
            this.Controls.Add(this.txtB_phoneEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtB_emailEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_nameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_idEmployee);
            this.Controls.Add(this.btn_addEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormEmploy";
            this.Text = "FormEmploy";
            this.Load += new System.EventHandler(this.FormEmploy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grView_hienthi7;
        private System.Windows.Forms.RadioButton rad_maleEmp;
        private System.Windows.Forms.TextBox txtB_dateEmp;
        private System.Windows.Forms.RadioButton rad_femaEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_exitEmp;
        private System.Windows.Forms.Button btn_deleEmp;
        private System.Windows.Forms.Button btn_updateEmp;
        private System.Windows.Forms.TextBox txtB_phoneEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB_emailEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_nameEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_idEmployee;
        private System.Windows.Forms.Button btn_addEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}