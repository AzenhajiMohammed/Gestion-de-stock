namespace Gestion_de_stock.PL
{
    partial class FRM_Ajouter_Modifier_Categorie
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 224);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(423, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 224);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 3);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(45, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Location = new System.Drawing.Point(68, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 2);
            this.panel5.TabIndex = 14;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTitre.Location = new System.Drawing.Point(12, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(283, 37);
            this.lblTitre.TabIndex = 28;
            this.lblTitre.Text = "Ajouter Categorie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_de_stock.Properties.Resources.categories1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 55);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Teal;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.White;
            this.txtNom.Location = new System.Drawing.Point(78, 75);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(315, 51);
            this.txtNom.TabIndex = 30;
            this.txtNom.Text = "Nom de Categorie";
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter_1);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Gestion_de_stock.Properties.Resources.technydisxxxxxxx;
            this.button2.Location = new System.Drawing.Point(379, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 40);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_Ajouter_Modifier_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(426, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Categorie";
            this.Text = "FRM_Ajouter_Modifier_Categorie";
            this.Load += new System.EventHandler(this.FRM_Ajouter_Modifier_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button button2;
    }
}