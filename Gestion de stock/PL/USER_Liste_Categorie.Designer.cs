namespace Gestion_de_stock.PL
{
    partial class USER_Liste_Categorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvCategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.BtnExel = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercher
            // 
            this.txtRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRechercher.Location = new System.Drawing.Point(367, 31);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(375, 35);
            this.txtRechercher.TabIndex = 13;
            this.txtRechercher.Text = "Recherche";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter_1);
            this.txtRechercher.Leave += new System.EventHandler(this.txtRechercher_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(367, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 2);
            this.panel3.TabIndex = 12;
            this.panel3.Enter += new System.EventHandler(this.txtRechercher_Enter_1);
            // 
            // DgvCategorie
            // 
            this.DgvCategorie.AllowUserToAddRows = false;
            this.DgvCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Modifier,
            this.Supprimer});
            this.DgvCategorie.EnableHeadersVisualStyles = false;
            this.DgvCategorie.Location = new System.Drawing.Point(3, 110);
            this.DgvCategorie.Name = "DgvCategorie";
            this.DgvCategorie.RowHeadersVisible = false;
            this.DgvCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCategorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCategorie.Size = new System.Drawing.Size(810, 231);
            this.DgvCategorie.TabIndex = 15;
            this.DgvCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategorie_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NomCategorie";
            this.Column3.Name = "Column3";
            // 
            // Modifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
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
            this.btnImprimerTout.Location = new System.Drawing.Point(71, 368);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(261, 48);
            this.btnImprimerTout.TabIndex = 17;
            this.btnImprimerTout.Text = "Imprimer Tout";
            this.btnImprimerTout.UseVisualStyleBackColor = false;
            this.btnImprimerTout.Click += new System.EventHandler(this.btnImprimerTout_Click);
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
            this.BtnExel.Location = new System.Drawing.Point(506, 368);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(236, 48);
            this.BtnExel.TabIndex = 16;
            this.BtnExel.Text = "sauvegarder";
            this.BtnExel.UseVisualStyleBackColor = false;
            this.BtnExel.Click += new System.EventHandler(this.BtnExel_Click);
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
            this.btnAjouter.Location = new System.Drawing.Point(28, 21);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(259, 53);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // USER_Liste_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerTout);
            this.Controls.Add(this.BtnExel);
            this.Controls.Add(this.DgvCategorie);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel3);
            this.Name = "USER_Liste_Categorie";
            this.Size = new System.Drawing.Size(816, 437);
            this.Load += new System.EventHandler(this.USER_Liste_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView DgvCategorie;
        private System.Windows.Forms.Button BtnExel;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
