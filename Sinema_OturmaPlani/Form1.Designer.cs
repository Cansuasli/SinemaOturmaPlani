namespace Sinema_OturmaPlani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKoltuklar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picbDoluKoltuk = new System.Windows.Forms.PictureBox();
            this.picbBosKoltuk = new System.Windows.Forms.PictureBox();
            this.imglKoltuklar = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbDoluKoltuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBosKoltuk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 52);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "SİNEMA OTOMASYONU";
            // 
            // gbKoltuklar
            // 
            this.gbKoltuklar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKoltuklar.Location = new System.Drawing.Point(12, 73);
            this.gbKoltuklar.Name = "gbKoltuklar";
            this.gbKoltuklar.Size = new System.Drawing.Size(691, 300);
            this.gbKoltuklar.TabIndex = 2;
            this.gbKoltuklar.TabStop = false;
            this.gbKoltuklar.Text = "Koltuklar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dolu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Boş";
            // 
            // picbDoluKoltuk
            // 
            this.picbDoluKoltuk.Location = new System.Drawing.Point(516, 379);
            this.picbDoluKoltuk.Name = "picbDoluKoltuk";
            this.picbDoluKoltuk.Size = new System.Drawing.Size(58, 43);
            this.picbDoluKoltuk.TabIndex = 5;
            this.picbDoluKoltuk.TabStop = false;
            // 
            // picbBosKoltuk
            // 
            this.picbBosKoltuk.Location = new System.Drawing.Point(645, 379);
            this.picbBosKoltuk.Name = "picbBosKoltuk";
            this.picbBosKoltuk.Size = new System.Drawing.Size(58, 43);
            this.picbBosKoltuk.TabIndex = 6;
            this.picbBosKoltuk.TabStop = false;
            // 
            // imglKoltuklar
            // 
            this.imglKoltuklar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglKoltuklar.ImageStream")));
            this.imglKoltuklar.TransparentColor = System.Drawing.Color.Transparent;
            this.imglKoltuklar.Images.SetKeyName(0, "Blue_Chair.png");
            this.imglKoltuklar.Images.SetKeyName(1, "Red_Chair.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 424);
            this.Controls.Add(this.picbBosKoltuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picbDoluKoltuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbKoltuklar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbDoluKoltuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBosKoltuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbKoltuklar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picbDoluKoltuk;
        private System.Windows.Forms.PictureBox picbBosKoltuk;
        private System.Windows.Forms.ImageList imglKoltuklar;
    }
}

