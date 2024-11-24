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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail= frm;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtRemise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantite.Text != "")
            {
            int quantite=int.Parse(txtQuantite.Text);
            int prix=int.Parse(lblPrix.Text);
                if (int.Parse(txtQuantite.Text) > int.Parse(lblStock.Text))
                {
                    MessageBox.Show("Il y a seulment " + int.Parse(lblStock.Text) + " dans stock","Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantite.Text = "";
                    txtTotal.Text = lblPrix.Text;
                }
                else
                {
                    txtTotal.Text = (quantite * prix).ToString();
                }
            //calcule total
            
            }
            else
            {
                txtTotal.Text=lblPrix.Text;
            }
            
        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {
            if(txtRemise.Text != "")
            {
                int quantite = int.Parse(txtQuantite.Text);
                int prix = int.Parse(lblPrix.Text);
                int total = quantite * prix;
                int remis = int.Parse(txtRemise.Text);
                txtTotal.Text= (total-(total * remis/100)).ToString();
            }
            else
            {
                int quantite = int.Parse(txtQuantite.Text);
                int prix = int.Parse(lblPrix.Text);
                txtTotal.Text= (quantite * prix).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ajouter produit dans dgv commande
            BL.D_Commande DETAIL = new BL.D_Commande
            {
                Id=int.Parse(lblid.Text),
                Nom=lblNom.Text,
                Quantite =int.Parse(txtQuantite.Text),
                Prix=lblPrix.Text,
                Remise=txtRemise.Text,
                Total=txtTotal.Text,
            };
            //ajouter dans liste
            if(lblProduitee.Text== "Vendre Produit")
            {
                if (BL.D_Commande.listeDetail.SingleOrDefault(s => s.Id == DETAIL.Id) != null)
                {
                    MessageBox.Show("Produit d'éja existe dans commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BL.D_Commande.listeDetail.Add(DETAIL);
                }
            }else
            //modifier produit
            {
                DialogResult PR = MessageBox.Show("Voulez-vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index=BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(lblid.Text));
                    BL.D_Commande.listeDetail[index]=DETAIL;
                    MessageBox.Show("Modification succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification Annule", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            }
            
            //actualiser datagrid
            (frmdetail as FRM_Detail_Commande).Actualise_DetailCommande();
        }

        private void FRM_Produit_Commande_Load(object sender, EventArgs e)
        {

        }
    }
}
