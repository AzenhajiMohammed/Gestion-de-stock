namespace Gestion_de_stock.PL
{
    partial class User_Liste_Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboRecherche = new System.Windows.Forms.ComboBox();
            this.DgvClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 3);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(3, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 3);
            this.panel2.TabIndex = 1;
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRechercher.Location = new System.Drawing.Point(412, 90);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(290, 35);
            this.txtRechercher.TabIndex = 2;
            this.txtRechercher.Text = "Recherche";
            this.txtRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            this.txtRechercher.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(412, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 2);
            this.panel3.TabIndex = 1;
            // 
            // comboRecherche
            // 
            this.comboRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRecherche.FormattingEnabled = true;
            this.comboRecherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comboRecherche.Location = new System.Drawing.Point(84, 90);
            this.comboRecherche.Name = "comboRecherche";
            this.comboRecherche.Size = new System.Drawing.Size(254, 33);
            this.comboRecherche.TabIndex = 3;
            this.comboRecherche.SelectedIndexChanged += new System.EventHandler(this.comboRecherche_SelectedIndexChanged);
            // 
            // DgvClient
            // 
            this.DgvClient.AllowUserToAddRows = false;
            this.DgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClient.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.DgvClient.EnableHeadersVisualStyles = false;
            this.DgvClient.Location = new System.Drawing.Point(3, 190);
            this.DgvClient.Name = "DgvClient";
            this.DgvClient.RowHeadersVisible = false;
            this.DgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvClient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvClient.Size = new System.Drawing.Size(810, 213);
            this.DgvClient.TabIndex = 4;
            this.DgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClient_CellContentClick);
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
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pays";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // BtnSupprimerClient
            // 
            this.BtnSupprimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSupprimerClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSupprimerClient.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerClient.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimerClient.Image = global::Gestion_de_stock.Properties.Resources.delete;
            this.BtnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimerClient.Location = new System.Drawing.Point(557, 3);
            this.BtnSupprimerClient.Name = "BtnSupprimerClient";
            this.BtnSupprimerClient.Size = new System.Drawing.Size(256, 72);
            this.BtnSupprimerClient.TabIndex = 0;
            this.BtnSupprimerClient.Text = "Supprimer";
            this.BtnSupprimerClient.UseVisualStyleBackColor = false;
            this.BtnSupprimerClient.Click += new System.EventHandler(this.BtnSupprimerClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifierClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModifierClient.FlatAppearance.BorderSize = 0;
            this.btnModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierClient.ForeColor = System.Drawing.Color.White;
            this.btnModifierClient.Image = global::Gestion_de_stock.Properties.Resources.edit;
            this.btnModifierClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierClient.Location = new System.Drawing.Point(279, 3);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(256, 72);
            this.btnModifierClient.TabIndex = 0;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterClient.FlatAppearance.BorderSize = 0;
            this.btnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.ForeColor = System.Drawing.Color.White;
            this.btnAjouterClient.Image = global::Gestion_de_stock.Properties.Resources.add_lient2;
            this.btnAjouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterClient.Location = new System.Drawing.Point(3, 3);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(256, 72);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // User_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvClient);
            this.Controls.Add(this.comboRecherche);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Name = "User_Liste_Client";
            this.Size = new System.Drawing.Size(816, 437);
            this.Load += new System.EventHandler(this.User_Liste_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button BtnSupprimerClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboRecherche;
        private System.Windows.Forms.DataGridView DgvClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
