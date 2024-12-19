namespace MetotBasitFaiz
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
            this.txtAnapara = new System.Windows.Forms.TextBox();
            this.txtFaizOrani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblToplamFaiz = new System.Windows.Forms.Label();
            this.lblToplamOdenecek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Para";
            // 
            // txtAnapara
            // 
            this.txtAnapara.Location = new System.Drawing.Point(127, 25);
            this.txtAnapara.Name = "txtAnapara";
            this.txtAnapara.Size = new System.Drawing.Size(171, 26);
            this.txtAnapara.TabIndex = 1;
            // 
            // txtFaizOrani
            // 
            this.txtFaizOrani.Location = new System.Drawing.Point(127, 57);
            this.txtFaizOrani.Name = "txtFaizOrani";
            this.txtFaizOrani.Size = new System.Drawing.Size(171, 26);
            this.txtFaizOrani.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faiz Oranı";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(127, 89);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(171, 26);
            this.txtSure.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(127, 121);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(171, 45);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblToplamFaiz
            // 
            this.lblToplamFaiz.AutoSize = true;
            this.lblToplamFaiz.Location = new System.Drawing.Point(355, 79);
            this.lblToplamFaiz.Name = "lblToplamFaiz";
            this.lblToplamFaiz.Size = new System.Drawing.Size(99, 20);
            this.lblToplamFaiz.TabIndex = 7;
            this.lblToplamFaiz.Text = "Toplam Faiz:";
            // 
            // lblToplamOdenecek
            // 
            this.lblToplamOdenecek.AutoSize = true;
            this.lblToplamOdenecek.Location = new System.Drawing.Point(355, 121);
            this.lblToplamOdenecek.Name = "lblToplamOdenecek";
            this.lblToplamOdenecek.Size = new System.Drawing.Size(142, 20);
            this.lblToplamOdenecek.TabIndex = 8;
            this.lblToplamOdenecek.Text = "Toplam Ödenecek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 241);
            this.Controls.Add(this.lblToplamOdenecek);
            this.Controls.Add(this.lblToplamFaiz);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFaizOrani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnapara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "yazilimkodlama.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnapara;
        private System.Windows.Forms.TextBox txtFaizOrani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblToplamFaiz;
        private System.Windows.Forms.Label lblToplamOdenecek;
    }
}

