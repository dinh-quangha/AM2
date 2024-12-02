namespace Clothing_Management
{
    partial class FormUserscs
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
            this.cbB_sizeSP = new System.Windows.Forms.ComboBox();
            this.txtB_Quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txtB_idSP = new System.Windows.Forms.TextBox();
            this.txtB_nameSP = new System.Windows.Forms.TextBox();
            this.txtB_sellSP = new System.Windows.Forms.TextBox();
            this.txtB_inventorySP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picB_image = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtB_searchSP = new System.Windows.Forms.TextBox();
            this.GrView_spUser = new System.Windows.Forms.DataGridView();
            this.txtB_nameCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtB_idUser = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrView_spUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbB_sizeSP
            // 
            this.cbB_sizeSP.FormattingEnabled = true;
            this.cbB_sizeSP.Items.AddRange(new object[] {
            "M",
            "L",
            "X"});
            this.cbB_sizeSP.Location = new System.Drawing.Point(799, 431);
            this.cbB_sizeSP.Name = "cbB_sizeSP";
            this.cbB_sizeSP.Size = new System.Drawing.Size(132, 24);
            this.cbB_sizeSP.TabIndex = 76;
            // 
            // txtB_Quantity
            // 
            this.txtB_Quantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtB_Quantity.Location = new System.Drawing.Point(799, 568);
            this.txtB_Quantity.Multiline = true;
            this.txtB_Quantity.Name = "txtB_Quantity";
            this.txtB_Quantity.Size = new System.Drawing.Size(100, 28);
            this.txtB_Quantity.TabIndex = 83;
            this.txtB_Quantity.TextChanged += new System.EventHandler(this.txtB_Quantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(634, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 22);
            this.label7.TabIndex = 86;
            this.label7.Text = "Purchase quantity:";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(731, 631);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(87, 27);
            this.btn_pay.TabIndex = 84;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click_1);
            // 
            // txtB_idSP
            // 
            this.txtB_idSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_idSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_idSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtB_idSP.Location = new System.Drawing.Point(785, 126);
            this.txtB_idSP.Multiline = true;
            this.txtB_idSP.Name = "txtB_idSP";
            this.txtB_idSP.ReadOnly = true;
            this.txtB_idSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_idSP.TabIndex = 72;
            // 
            // txtB_nameSP
            // 
            this.txtB_nameSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_nameSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_nameSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtB_nameSP.Location = new System.Drawing.Point(785, 169);
            this.txtB_nameSP.Multiline = true;
            this.txtB_nameSP.Name = "txtB_nameSP";
            this.txtB_nameSP.ReadOnly = true;
            this.txtB_nameSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_nameSP.TabIndex = 74;
            // 
            // txtB_sellSP
            // 
            this.txtB_sellSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_sellSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_sellSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtB_sellSP.Location = new System.Drawing.Point(799, 520);
            this.txtB_sellSP.Multiline = true;
            this.txtB_sellSP.Name = "txtB_sellSP";
            this.txtB_sellSP.ReadOnly = true;
            this.txtB_sellSP.Size = new System.Drawing.Size(132, 24);
            this.txtB_sellSP.TabIndex = 78;
            // 
            // txtB_inventorySP
            // 
            this.txtB_inventorySP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_inventorySP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_inventorySP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtB_inventorySP.Location = new System.Drawing.Point(799, 475);
            this.txtB_inventorySP.Multiline = true;
            this.txtB_inventorySP.Name = "txtB_inventorySP";
            this.txtB_inventorySP.ReadOnly = true;
            this.txtB_inventorySP.Size = new System.Drawing.Size(132, 24);
            this.txtB_inventorySP.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "Inventory: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 80;
            this.label5.Text = "Selling:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Size:";
            // 
            // picB_image
            // 
            this.picB_image.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picB_image.Location = new System.Drawing.Point(657, 208);
            this.picB_image.Name = "picB_image";
            this.picB_image.Size = new System.Drawing.Size(260, 205);
            this.picB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_image.TabIndex = 77;
            this.picB_image.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "IDProduct:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(926, 84);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 28);
            this.btn_search.TabIndex = 71;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtB_searchSP
            // 
            this.txtB_searchSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtB_searchSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_searchSP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtB_searchSP.Location = new System.Drawing.Point(593, 84);
            this.txtB_searchSP.Multiline = true;
            this.txtB_searchSP.Name = "txtB_searchSP";
            this.txtB_searchSP.Size = new System.Drawing.Size(274, 28);
            this.txtB_searchSP.TabIndex = 70;
            // 
            // GrView_spUser
            // 
            this.GrView_spUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrView_spUser.Location = new System.Drawing.Point(2, 151);
            this.GrView_spUser.Name = "GrView_spUser";
            this.GrView_spUser.RowHeadersWidth = 51;
            this.GrView_spUser.Size = new System.Drawing.Size(569, 507);
            this.GrView_spUser.TabIndex = 85;
            this.GrView_spUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrView_spUser_CellContentClick);
            // 
            // txtB_nameCustomer
            // 
            this.txtB_nameCustomer.BackColor = System.Drawing.Color.Green;
            this.txtB_nameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_nameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_nameCustomer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtB_nameCustomer.Location = new System.Drawing.Point(2, 71);
            this.txtB_nameCustomer.Multiline = true;
            this.txtB_nameCustomer.Name = "txtB_nameCustomer";
            this.txtB_nameCustomer.ReadOnly = true;
            this.txtB_nameCustomer.Size = new System.Drawing.Size(463, 47);
            this.txtB_nameCustomer.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 68;
            this.label1.Text = "Product Customer";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(245, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 28);
            this.textBox1.TabIndex = 67;
            // 
            // txtB_idUser
            // 
            this.txtB_idUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtB_idUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_idUser.Location = new System.Drawing.Point(263, 224);
            this.txtB_idUser.Multiline = true;
            this.txtB_idUser.Name = "txtB_idUser";
            this.txtB_idUser.Size = new System.Drawing.Size(194, 28);
            this.txtB_idUser.TabIndex = 66;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(3, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1053, 72);
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // FormUserscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1055, 657);
            this.Controls.Add(this.cbB_sizeSP);
            this.Controls.Add(this.txtB_Quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txtB_idSP);
            this.Controls.Add(this.txtB_nameSP);
            this.Controls.Add(this.txtB_sellSP);
            this.Controls.Add(this.txtB_inventorySP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picB_image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtB_searchSP);
            this.Controls.Add(this.GrView_spUser);
            this.Controls.Add(this.txtB_nameCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtB_idUser);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormUserscs";
            this.Text = "FormUserscs";
            this.Load += new System.EventHandler(this.FormUserscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrView_spUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbB_sizeSP;
        private System.Windows.Forms.TextBox txtB_Quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.TextBox txtB_idSP;
        private System.Windows.Forms.TextBox txtB_nameSP;
        private System.Windows.Forms.TextBox txtB_sellSP;
        private System.Windows.Forms.TextBox txtB_inventorySP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picB_image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtB_searchSP;
        private System.Windows.Forms.DataGridView GrView_spUser;
        private System.Windows.Forms.TextBox txtB_nameCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtB_idUser;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}