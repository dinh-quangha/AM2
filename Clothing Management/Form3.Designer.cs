﻿namespace Clothing_Management
{
    partial class Form3
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
            this.grView_hienthi = new System.Windows.Forms.DataGridView();
            this.txtB_dateCustomer = new System.Windows.Forms.TextBox();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_fema = new System.Windows.Forms.RadioButton();
            this.btn_exitCustomer = new System.Windows.Forms.Button();
            this.btn_deleCustomer = new System.Windows.Forms.Button();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.txtB_emailCustomer = new System.Windows.Forms.TextBox();
            this.txtB_phoneCustomer = new System.Windows.Forms.TextBox();
            this.txtB_nameCustomer = new System.Windows.Forms.TextBox();
            this.txtB_idCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grView_hienthi
            // 
            this.grView_hienthi.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.grView_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grView_hienthi.Location = new System.Drawing.Point(23, 332);
            this.grView_hienthi.Name = "grView_hienthi";
            this.grView_hienthi.RowHeadersWidth = 51;
            this.grView_hienthi.RowTemplate.Height = 24;
            this.grView_hienthi.Size = new System.Drawing.Size(911, 181);
            this.grView_hienthi.TabIndex = 42;
            this.grView_hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grView_hienthi_CellContentClick);
            // 
            // txtB_dateCustomer
            // 
            this.txtB_dateCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_dateCustomer.Location = new System.Drawing.Point(678, 85);
            this.txtB_dateCustomer.Name = "txtB_dateCustomer";
            this.txtB_dateCustomer.Size = new System.Drawing.Size(209, 22);
            this.txtB_dateCustomer.TabIndex = 33;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_male.Location = new System.Drawing.Point(169, 238);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(68, 20);
            this.rad_male.TabIndex = 36;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "MALE";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_fema
            // 
            this.rad_fema.AutoSize = true;
            this.rad_fema.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_fema.Location = new System.Drawing.Point(272, 238);
            this.rad_fema.Name = "rad_fema";
            this.rad_fema.Size = new System.Drawing.Size(87, 20);
            this.rad_fema.TabIndex = 37;
            this.rad_fema.TabStop = true;
            this.rad_fema.Text = "FEMALE";
            this.rad_fema.UseVisualStyleBackColor = true;
            // 
            // btn_exitCustomer
            // 
            this.btn_exitCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exitCustomer.Location = new System.Drawing.Point(753, 280);
            this.btn_exitCustomer.Name = "btn_exitCustomer";
            this.btn_exitCustomer.Size = new System.Drawing.Size(91, 27);
            this.btn_exitCustomer.TabIndex = 41;
            this.btn_exitCustomer.Text = "EXIT";
            this.btn_exitCustomer.UseVisualStyleBackColor = false;
            this.btn_exitCustomer.Click += new System.EventHandler(this.btn_exitCustomer_Click);
            // 
            // btn_deleCustomer
            // 
            this.btn_deleCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleCustomer.Location = new System.Drawing.Point(753, 231);
            this.btn_deleCustomer.Name = "btn_deleCustomer";
            this.btn_deleCustomer.Size = new System.Drawing.Size(91, 27);
            this.btn_deleCustomer.TabIndex = 40;
            this.btn_deleCustomer.Text = "DELETE";
            this.btn_deleCustomer.UseVisualStyleBackColor = false;
            this.btn_deleCustomer.Click += new System.EventHandler(this.btn_deleCustomer_Click);
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_updateCustomer.Location = new System.Drawing.Point(602, 280);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(91, 27);
            this.btn_updateCustomer.TabIndex = 39;
            this.btn_updateCustomer.Text = "UPDATE";
            this.btn_updateCustomer.UseVisualStyleBackColor = false;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addCustomer.Location = new System.Drawing.Point(602, 231);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(91, 27);
            this.btn_addCustomer.TabIndex = 38;
            this.btn_addCustomer.Text = "ADD";
            this.btn_addCustomer.UseVisualStyleBackColor = false;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // txtB_emailCustomer
            // 
            this.txtB_emailCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_emailCustomer.Location = new System.Drawing.Point(678, 188);
            this.txtB_emailCustomer.Name = "txtB_emailCustomer";
            this.txtB_emailCustomer.Size = new System.Drawing.Size(209, 22);
            this.txtB_emailCustomer.TabIndex = 35;
            // 
            // txtB_phoneCustomer
            // 
            this.txtB_phoneCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_phoneCustomer.Location = new System.Drawing.Point(678, 136);
            this.txtB_phoneCustomer.Name = "txtB_phoneCustomer";
            this.txtB_phoneCustomer.Size = new System.Drawing.Size(209, 22);
            this.txtB_phoneCustomer.TabIndex = 34;
            // 
            // txtB_nameCustomer
            // 
            this.txtB_nameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_nameCustomer.Location = new System.Drawing.Point(257, 179);
            this.txtB_nameCustomer.Multiline = true;
            this.txtB_nameCustomer.Name = "txtB_nameCustomer";
            this.txtB_nameCustomer.Size = new System.Drawing.Size(162, 24);
            this.txtB_nameCustomer.TabIndex = 32;
            // 
            // txtB_idCustomer
            // 
            this.txtB_idCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_idCustomer.Location = new System.Drawing.Point(257, 114);
            this.txtB_idCustomer.Name = "txtB_idCustomer";
            this.txtB_idCustomer.Size = new System.Drawing.Size(162, 22);
            this.txtB_idCustomer.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Number Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Get Customer Data";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(23, -14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(911, 58);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 515);
            this.Controls.Add(this.grView_hienthi);
            this.Controls.Add(this.txtB_dateCustomer);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.rad_fema);
            this.Controls.Add(this.btn_exitCustomer);
            this.Controls.Add(this.btn_deleCustomer);
            this.Controls.Add(this.btn_updateCustomer);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.txtB_emailCustomer);
            this.Controls.Add(this.txtB_phoneCustomer);
            this.Controls.Add(this.txtB_nameCustomer);
            this.Controls.Add(this.txtB_idCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grView_hienthi;
        private System.Windows.Forms.TextBox txtB_dateCustomer;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_fema;
        private System.Windows.Forms.Button btn_exitCustomer;
        private System.Windows.Forms.Button btn_deleCustomer;
        private System.Windows.Forms.Button btn_updateCustomer;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.TextBox txtB_emailCustomer;
        private System.Windows.Forms.TextBox txtB_phoneCustomer;
        private System.Windows.Forms.TextBox txtB_nameCustomer;
        private System.Windows.Forms.TextBox txtB_idCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}