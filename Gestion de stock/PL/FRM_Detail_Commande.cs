using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_stock.PL
{

    public partial class FRM_Detail_Commande : Form
    {
        private UserControl usercommande;
        private DbStockContext db;
        
        public FRM_Detail_Commande(UserControl user)
        {
            InitializeComponent();
            db = new DbStockContext();
            usercommande = user;
        }
        //remplir datagrid de commande pa liste
        public void Actualise_DetailCommande()
        {
            //calcule total ht,tva,total ttc
            float Totalht = 0,TVA=0,ToTalttc =0;
            if (txttva.Text != "")
            {
                TVA=float.Parse(txttva.Text);
            }
            dgvDetailCommande.Rows.Clear();
            foreach(var L in BL.D_Commande.listeDetail)
            {
                dgvDetailCommande.Rows.Add(L.Id,L.Nom,L.Quantite,L.Prix,L.Remise,L.Total);
                Totalht=Totalht + float.Parse(L.Total);
            }
            txtTotalHT.Text = Totalht.ToString();
            //calcule total ttc 
            ToTalttc = (Totalht + (Totalht * TVA / 100));
            //calcule total ttc dans textbox ttc
            txtTTTC.Text = ToTalttc.ToString();
        }
        //fonction Remplir datagrid de produit
        public void RemplirdgvProduit()
        {
            db=new DbStockContext();
            foreach (var l in db.Produits)
            {
                dgvProduit.Rows.Add(l.Id_produit,l.Nom_Produit,l.Quantite_Produit,l.Prix_Produit);
            }
            //colorer stock vide en rouge
            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((int)dgvProduit.Rows[i].Cells[2].Value == 0)//si stock ==0
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                }
            }
            dgvProduit.ClearSelection();
        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            RemplirdgvProduit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.White;
            }
        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listerecherche = db.Produits.ToList();//listerecherche = liste client

            //recherche seulment par nom de produit
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            //vider datagridview
            dgvProduit.Rows.Clear();
            
            foreach (var l in listerecherche)
            {
             
                dgvProduit.Rows.Add(l.Id_produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
            frmC.ShowDialog();
            //afficher les information de clients
            IDCLIENT=(int)frmC.DgvClient.CurrentRow.Cells[0].Value;
            txtNom.Text = frmC.DgvClient.CurrentRow.Cells[1].Value.ToString();
            txtPrenomc.Text = frmC.DgvClient.CurrentRow.Cells[2].Value.ToString();
            txtTelephonec.Text = frmC.DgvClient.CurrentRow.Cells[4].Value.ToString();
            txtEmailC.Text = frmC.DgvClient.CurrentRow.Cells[5].Value.ToString();
            txtPaysC.Text = frmC.DgvClient.CurrentRow.Cells[6].Value.ToString();
            txtVilleP.Text = frmC.DgvClient.CurrentRow.Cells[7].Value.ToString();

        }

        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            if((int)dgvProduit.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("Stock vide","Stock",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                frmp.lblid.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
                frmp.lblNom.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
            frmp.lblStock.Text = dgvProduit.CurrentRow.Cells[2].Value.ToString();
            frmp.lblPrix.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
             frmp.txtTotal.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
            frmp.ShowDialog();

            }
           

           
            

        }

        private void dgvProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            if (dgvDetailCommande.CurrentRow != null)
            {
                frm.lblProduitee.Text = "Modifier Produit";
                //afficher information de produitmodifier
                frm.lblid.Text = dgvDetailCommande.CurrentRow.Cells[0].Value.ToString();
                frm.lblNom.Text = dgvDetailCommande.CurrentRow.Cells[1].Value.ToString();
                //importer stock de produit
                int IDP = int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString());
                PR = db.Produits.Single(s => s.Id_produit == IDP);
                frm.lblStock.Text = PR.Quantite_Produit.ToString();
                /////////
                frm.lblPrix.Text = dgvDetailCommande.CurrentRow.Cells[3].Value.ToString();
                frm.txtQuantite.Text= dgvDetailCommande.CurrentRow.Cells[2].Value.ToString();
                frm.txtRemise.Text = dgvDetailCommande.CurrentRow.Cells[4].Value.ToString();
                frm.txtTotal.Text = dgvDetailCommande.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetailCommande.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    //supprimer produit commande dans la liste
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Commande.listeDetail.RemoveAt(index);
                    //actualise datagrid
                    Actualise_DetailCommande();
                    MessageBox.Show("Suppression Succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annuler", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            //vider la liste des produit commander
            BL.D_Commande.listeDetail.Clear();
        }

        private void txttva_TextChanged(object sender, EventArgs e)
        {
            //calcule ttc
            Actualise_DetailCommande();
        }
        //id client
        public int IDCLIENT;

        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clscommande = new BL.CLS_Commande_DetailCommande();
            if (dgvDetailCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter des Produit", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtNom.Text == "")
                {
                    MessageBox.Show("Ajouter un Client","Client",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //enregidtrer commande
                    clscommande.Ajouter_Commande(commandeDate.Value, IDCLIENT, txtTotalHT.Text, txttva.Text, txtTTTC.Text);
                    //enregistrer liste detail commande daans base de donne
                    foreach(var LD in BL.D_Commande.listeDetail)
                    {
                        clscommande.Ajouter_Detail(LD.Id, LD.Nom, LD.Quantite, LD.Prix, LD.Remise, LD.Total);
                    }
                    (usercommande as User_Liste_Commande).Remplirdata();
                    //vider liste
                    BL.D_Commande.listeDetail.Clear();
                    //quitter form
                    Close();
                    MessageBox.Show("Commande Ajouter avec succes", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }
    }
}
