namespace C_SHARP_TINHLAINGANHANG
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLaisuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonam = new System.Windows.Forms.TextBox();
            this.btbTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(208, 287);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(212, 134);
            this.lbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "TÍNH LÃI SUẤT NGÂN HÀNG";
            // 
            // txtSotien
            // 
            this.txtSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.Location = new System.Drawing.Point(320, 111);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(100, 26);
            this.txtSotien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lãi suất";
            // 
            // txtLaisuat
            // 
            this.txtLaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaisuat.Location = new System.Drawing.Point(320, 152);
            this.txtLaisuat.Name = "txtLaisuat";
            this.txtLaisuat.Size = new System.Drawing.Size(100, 26);
            this.txtLaisuat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số năm gửi";
            // 
            // txtSonam
            // 
            this.txtSonam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonam.Location = new System.Drawing.Point(320, 195);
            this.txtSonam.Name = "txtSonam";
            this.txtSonam.Size = new System.Drawing.Size(100, 26);
            this.txtSonam.TabIndex = 3;
            // 
            // btbTinh
            // 
            this.btbTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbTinh.Location = new System.Drawing.Point(320, 239);
            this.btbTinh.Name = "btbTinh";
            this.btbTinh.Size = new System.Drawing.Size(100, 23);
            this.btbTinh.TabIndex = 4;
            this.btbTinh.Text = "Tính";
            this.btbTinh.UseVisualStyleBackColor = true;
            this.btbTinh.Click += new System.EventHandler(this.btbTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbTinh);
            this.Controls.Add(this.txtSonam);
            this.Controls.Add(this.txtLaisuat);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLaisuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonam;
        private System.Windows.Forms.Button btbTinh;
    }
}

