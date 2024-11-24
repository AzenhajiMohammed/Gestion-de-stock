namespace Gestion_de_stock.PL
{
    partial class User_Liste_Commande
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvcommande = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCherche = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcommande
            // 
            this.dgvcommande.AllowUserToAddRows = false;
            this.dgvcommande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcommande.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Client,
            this.TotalHt,
            this.TVA,
            this.TotalTTC});
            this.dgvcommande.EnableHeadersVisualStyles = false;
            this.dgvcommande.Location = new System.Drawing.Point(3, 116);
            this.dgvcommande.Name = "dgvcommande";
            this.dgvcommande.RowHeadersVisible = false;
            this.dgvcommande.Size = new System.Drawing.Size(800, 259);
            this.dgvcommande.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // TotalHt
            // 
            this.TotalHt.HeaderText = "Total Ht";
            this.TotalHt.Name = "TotalHt";
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA%";
            this.TVA.Name = "TVA";
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total TTC";
            this.TotalTTC.Name = "TotalTTC";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateF
            // 
            this.dateF.Location = new System.Drawing.Point(390, 78);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(183, 20);
            this.dateF.TabIndex = 8;
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(390, 28);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(183, 20);
            this.dateD.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Gestion_de_stock.Properties.Resources.printing;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(457, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Imprimer Commande";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnCherche
            // 
            this.btnCherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCherche.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCherche.FlatAppearance.BorderSize = 0;
            this.btnCherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCherche.Image = global::Gestion_de_stock.Properties.Resources.business;
            this.btnCherche.Location = new System.Drawing.Point(638, 41);
            this.btnCherche.Name = "btnCherche";
            this.btnCherche.Size = new System.Drawing.Size(139, 35);
            this.btnCherche.TabIndex = 10;
            this.btnCherche.UseVisualStyleBackColor = false;
            this.btnCherche.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Gestion_de_stock.Properties.Resources.add_lient2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date Début:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(246, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date Fin:";
            // 
            // User_Liste_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCherche);
            this.Controls.Add(this.dateD);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.dgvcommande);
            this.Controls.Add(this.button1);
            this.Name = "User_Liste_Commande";
            this.Size = new System.Drawing.Size(806, 434);
            this.Load += new System.EventHandler(this.User_Liste_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvcommande;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Button btnCherche;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
