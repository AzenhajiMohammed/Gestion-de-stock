using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_stock.PL
{
    
    public partial class FRM_Menu : Form
    {
        
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(196, 505);
            PnlParamettrer.Visible = false;
        }
        // desactiver formulaire
        void desactiverForm()
        {
            BtnClient.Enabled = false;
            BtnProduit.Enabled = false;
            BtnCategorie.Enabled = false;
            BtnCommande.Enabled = false;
            BtnUtilisateur.Enabled = false;
            btnRestore.Enabled = false;
            btnUpload.Enabled = false;
            btnDeconncter.Enabled = false;
            btnConncter.Enabled = true;

        }
        // ACTIVER FORMULAIE
        public void activerFrm()
        {
            BtnClient.Enabled = true;
            BtnProduit.Enabled = true;
            BtnCategorie.Enabled = true;
            BtnCommande.Enabled = true;
            BtnUtilisateur.Enabled = true;
            btnRestore.Enabled = true;
            btnUpload.Enabled = true;
            btnDeconncter.Enabled = true;
            btnConncter.Enabled = false; 
            PnlParamettrer.Visible=false;
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            
            if (!pnlAfficher.Controls.Contains(User_Liste_Client.Instance))
            {
                pnlAfficher.Controls.Add(User_Liste_Client.Instance);
                User_Liste_Client.Instance.Dock = DockStyle.Fill;
                User_Liste_Client.Instance.BringToFront();
            }
            else
            {
                User_Liste_Client.Instance.BringToFront();
            }
            
        }

        private void Produit_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(User_List_Produit.Instance))
            {
                pnlAfficher.Controls.Add(User_List_Produit.Instance);
                User_List_Produit.Instance.Dock = DockStyle.Fill;
                User_List_Produit.Instance.BringToFront();
            }
            else
            {
                User_List_Produit.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Width==196)
            {
                panel1.Size = new Size(68, 505);
            }
            else
            {
                panel1.Size = new Size(196, 505);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PnlParamettrer.Size = new Size(304, 181);
            PnlParamettrer.Visible= !PnlParamettrer.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_connexion FrmC = new frm_connexion(this);//this == FRM_MENU
            FrmC.ShowDialog();
        }

        private void btnDeconncter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(USER_Liste_Categorie.Instance))
            {
                pnlAfficher.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();
            }
        }

        private void BtnCommande_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(User_Liste_Commande.Instance))
            {
                pnlAfficher.Controls.Add(User_Liste_Commande.Instance);
                User_Liste_Commande.Instance.Dock = DockStyle.Fill;
                User_Liste_Commande.Instance.BringToFront();
            }
            else
            {
                User_Liste_Commande.Instance.BringToFront();
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
