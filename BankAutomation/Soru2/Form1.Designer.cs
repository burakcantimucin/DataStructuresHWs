namespace Soru2
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
            this.btnBankaIslemi = new System.Windows.Forms.Button();
            this.lblTurgutluBankasi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBankaIslemi
            // 
            this.btnBankaIslemi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaIslemi.Location = new System.Drawing.Point(20, 145);
            this.btnBankaIslemi.Name = "btnBankaIslemi";
            this.btnBankaIslemi.Size = new System.Drawing.Size(332, 50);
            this.btnBankaIslemi.TabIndex = 0;
            this.btnBankaIslemi.Text = "20 KİŞİLİK KUYRUĞUN İŞLEMLERİNİ KONTROL ET";
            this.btnBankaIslemi.UseVisualStyleBackColor = true;
            this.btnBankaIslemi.Click += new System.EventHandler(this.btnBankaIslemi_Click);
            // 
            // lblTurgutluBankasi
            // 
            this.lblTurgutluBankasi.AutoSize = true;
            this.lblTurgutluBankasi.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurgutluBankasi.Location = new System.Drawing.Point(51, 85);
            this.lblTurgutluBankasi.Name = "lblTurgutluBankasi";
            this.lblTurgutluBankasi.Size = new System.Drawing.Size(271, 32);
            this.lblTurgutluBankasi.TabIndex = 1;
            this.lblTurgutluBankasi.Text = "Turgutlu Bankası";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 285);
            this.Controls.Add(this.lblTurgutluBankasi);
            this.Controls.Add(this.btnBankaIslemi);
            this.Name = "Form1";
            this.Text = "Turgutlu Bankası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBankaIslemi;
        private System.Windows.Forms.Label lblTurgutluBankasi;
    }
}

