namespace Gestion_de_stock.PL
{
    partial class FRM_Photo_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProduitImage = new System.Windows.Forms.PictureBox();
            this.ProduitNom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(644, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 3);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 447);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 3);
            this.panel4.TabIndex = 0;
            // 
            // ProduitImage
            // 
            this.ProduitImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduitImage.BackColor = System.Drawing.Color.White;
            this.ProduitImage.Location = new System.Drawing.Point(12, 51);
            this.ProduitImage.Name = "ProduitImage";
            this.ProduitImage.Size = new System.Drawing.Size(626, 390);
            this.ProduitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProduitImage.TabIndex = 27;
            this.ProduitImage.TabStop = false;
            // 
            // ProduitNom
            // 
            this.ProduitNom.AutoSize = true;
            this.ProduitNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduitNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProduitNom.Location = new System.Drawing.Point(268, 9);
            this.ProduitNom.Name = "ProduitNom";
            this.ProduitNom.Size = new System.Drawing.Size(99, 33);
            this.ProduitNom.TabIndex = 28;
            this.ProduitNom.Text = "label1";
            this.ProduitNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Gestion_de_stock.Properties.Resources.technydisxxxxxxx;
            this.button1.Location = new System.Drawing.Point(600, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 40);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Photo_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProduitNom);
            this.Controls.Add(this.ProduitImage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Photo_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Photo_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.ProduitImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox ProduitImage;
        public System.Windows.Forms.Label ProduitNom;
        private System.Windows.Forms.Button button1;
    }
}