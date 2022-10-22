namespace Calculator
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSob = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(38, 37);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(27, 13);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "so 1";
            // 
            // lbSob
            // 
            this.lbSob.AutoSize = true;
            this.lbSob.Location = new System.Drawing.Point(38, 87);
            this.lbSob.Name = "lbSob";
            this.lbSob.Size = new System.Drawing.Size(27, 13);
            this.lbSob.TabIndex = 1;
            this.lbSob.Text = "so 2";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(108, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(178, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(108, 87);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(178, 20);
            this.txtB.TabIndex = 3;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(38, 136);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(44, 13);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Ket qua";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(108, 136);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(178, 20);
            this.txtKetQua.TabIndex = 5;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(81, 230);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(79, 44);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cong";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(364, 230);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(79, 44);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "Tru";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 359);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbSob);
            this.Controls.Add(this.lbSoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSob;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

