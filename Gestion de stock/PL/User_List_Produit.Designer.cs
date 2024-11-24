namespace Gestion_de_stock.PL
{
    partial class User_List_Produit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExel = new System.Windows.Forms.Button();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.btnImprimerSelect = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnAfficherPhoto = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduit
            // 
            this.DgvProduit.AllowUserToAddRows = false;
            this.DgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvProduit.EnableHeadersVisualStyles = false;
            this.DgvProduit.Location = new System.Drawing.Point(3, 205);
            this.DgvProduit.Name = "DgvProduit";
            this.DgvProduit.RowHeadersVisible = false;
            this.DgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProduit.Size = new System.Drawing.Size(810, 175);
            this.DgvProduit.TabIndex = 13;
            this.DgvProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.Name = "Column5";
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRechercher.Location = new System.Drawing.Point(80, 118);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(375, 35);
            this.txtRechercher.TabIndex = 11;
            this.txtRechercher.Text = "Recherche";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
            this.txtRechercher.Leave += new System.EventHandler(this.txtRechercher_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(80, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 2);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 3);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 3);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Gestion_de_stock.Properties.Resources.refresh_button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(595, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExel
            // 
            this.BtnExel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExel.FlatAppearance.BorderSize = 0;
            this.BtnExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExel.ForeColor = System.Drawing.Color.White;
            this.BtnExel.Image = global::Gestion_de_stock.Properties.Resources.save_instagram;
            this.BtnExel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExel.Location = new System.Drawing.Point(577, 386);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(236, 48);
            this.BtnExel.TabIndex = 14;
            this.BtnExel.Text = "sauvegarder";
            this.BtnExel.UseVisualStyleBackColor = false;
            this.BtnExel.Click += new System.EventHandler(this.BtnExel_Click);
            // 
            // btnImprimerTout
            // 
            this.btnImprimerTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimerTout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimerTout.FlatAppearance.BorderSize = 0;
            this.btnImprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerTout.ForeColor = System.Drawing.Color.White;
            this.btnImprimerTout.Image = global::Gestion_de_stock.Properties.Resources.printing;
            this.btnImprimerTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimerTout.Location = new System.Drawing.Point(310, 386);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(261, 48);
            this.btnImprimerTout.TabIndex = 15;
            this.btnImprimerTout.Text = "Imprimer Tout";
            this.btnImprimerTout.UseVisualStyleBackColor = false;
            this.btnImprimerTout.Click += new System.EventHandler(this.btnImprimerTout_Click);
            // 
            // btnImprimerSelect
            // 
            this.btnImprimerSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimerSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimerSelect.FlatAppearance.BorderSize = 0;
            this.btnImprimerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSelect.ForeColor = System.Drawing.Color.White;
            this.btnImprimerSelect.Image = global::Gestion_de_stock.Properties.Resources.printing;
            this.btnImprimerSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimerSelect.Location = new System.Drawing.Point(3, 386);
            this.btnImprimerSelect.Name = "btnImprimerSelect";
            this.btnImprimerSelect.Size = new System.Drawing.Size(301, 48);
            this.btnImprimerSelect.TabIndex = 16;
            this.btnImprimerSelect.Text = "Ajouter";
            this.btnImprimerSelect.UseVisualStyleBackColor = false;
            this.btnImprimerSelect.Click += new System.EventHandler(this.btnImprimerSelect_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSupprimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.Image = global::Gestion_de_stock.Properties.Resources.delete;
            this.BtnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimer.Location = new System.Drawing.Point(410, 18);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(198, 53);
            this.BtnSupprimer.TabIndex = 5;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnAfficherPhoto
            // 
            this.BtnAfficherPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAfficherPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAfficherPhoto.FlatAppearance.BorderSize = 0;
            this.BtnAfficherPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfficherPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherPhoto.ForeColor = System.Drawing.Color.White;
            this.BtnAfficherPhoto.Image = global::Gestion_de_stock.Properties.Resources.image;
            this.BtnAfficherPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherPhoto.Location = new System.Drawing.Point(617, 18);
            this.BtnAfficherPhoto.Name = "BtnAfficherPhoto";
            this.BtnAfficherPhoto.Size = new System.Drawing.Size(198, 53);
            this.BtnAfficherPhoto.TabIndex = 5;
            this.BtnAfficherPhoto.Text = "   Afficher photo";
            this.BtnAfficherPhoto.UseVisualStyleBackColor = false;
            this.BtnAfficherPhoto.Click += new System.EventHandler(this.BtnAfficherPhoto_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifier.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = global::Gestion_de_stock.Properties.Resources.edit;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(206, 18);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(198, 53);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::Gestion_de_stock.Properties.Resources.add_lient2;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(2, 18);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(198, 53);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // User_List_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExel);
            this.Controls.Add(this.btnImprimerTout);
            this.Controls.Add(this.btnImprimerSelect);
            this.Controls.Add(this.DgvProduit);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnAfficherPhoto);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "User_List_Produit";
            this.Size = new System.Drawing.Size(816, 437);
            this.Load += new System.EventHandler(this.User_List_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduit;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAfficherPhoto;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnExel;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.Button btnImprimerSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}
