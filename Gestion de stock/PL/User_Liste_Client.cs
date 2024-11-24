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
    public partial class User_Liste_Client : UserControl
    {
        private static User_Liste_Client UserClient;
        private DbStockContext db;
        //creer un instance pour usercontrole
        public static User_Liste_Client Instance
        {
            get
            {
                if(UserClient == null)
                {
                    UserClient = new User_Liste_Client();
                }return UserClient;
            }

        }


        public User_Liste_Client()
        {
            InitializeComponent();
            db= new DbStockContext();
            txtRechercher.Enabled = false;
        }
        //Ajouter les donnes dans datagridview
        public void Actualisedatagrid()
        {
            db = new DbStockContext();
            DgvClient.Rows.Clear();
            foreach(var S in db.Clients)
            {
                DgvClient.Rows.Add(false,S.ID_CLIENT,S.Nom_Client,S.Prenom_Client,S.Adresse_Client,S.Telephonne_Client,S.Email_Client,S.Ville_Client,S.Pays_Client);
            }

        }
        //verifier combien en ligne est seletionner
        public string SelectVerif()
        {
            int Nombreligneselect =0;
            for (int i = 0; i < DgvClient.Rows.Count; i++)
            {
                if ((bool)DgvClient.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
                if(Nombreligneselect==0)
                {
                    return "Selectionner le Client Que vous-voulez modifier ";
                }
                if (Nombreligneselect >1)
                {
                    return "Selectionner seulment 1 seul Client pour modifier ";
                }
               

            } 
            return null;
        }
        
        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new PL.FRM_Ajouter_Modifier_Client(this);
            if (SelectVerif() == null)
            {
                for(int i = 0; i < DgvClient.Rows.Count; i++)
                {
                    if ((bool)DgvClient.Rows[i].Cells[0].Value == true)//cest le check box vrai afficher les informatin dans la formulaire client
                    {
                        frmclient.IdSelect = (int)DgvClient.Rows[i].Cells[1].Value;
                        frmclient.TxtNom.Text=DgvClient.Rows[i].Cells[2].Value.ToString();
                        frmclient.txtPrenom.Text = DgvClient.Rows[i].Cells[3].Value.ToString();
                        frmclient.txtAdresse.Text = DgvClient.Rows[i].Cells[4].Value.ToString();
                        frmclient.txtTelephone.Text = DgvClient.Rows[i].Cells[5].Value.ToString();
                        frmclient.txtEmail.Text = DgvClient.Rows[i].Cells[6].Value.ToString();
                        frmclient.txtVille.Text = DgvClient.Rows[i].Cells[7].Value.ToString();
                        frmclient.txtPays.Text = DgvClient.Rows[i].Cells[8].Value.ToString();
                    }
                }
                frmclient.LblTitre.Text = "Modifier Client";
                frmclient.btnActualiser.Visible = false;
                frmclient.ShowDialog();

            }
            else
            {
                MessageBox.Show(SelectVerif(),"Modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void User_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        public int IdSELECT;
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client FrmClient= new FRM_Ajouter_Modifier_Client(this);    
            FrmClient.ShowDialog();
        }

        private void BtnSupprimerClient_Click(object sender, EventArgs e)
        {
             BL.CLS_Client cLS_Client = new BL.CLS_Client();
            //pour supprimer tout les client selectionner
            int select = 0;
            for (int i = 0;i< DgvClient.Rows.Count; i++)
            {
                if ((bool)DgvClient.Rows[i].Cells[0].Value == true)
                {
                    select++;//combien de ligne selectionnez
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun client selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R =
                    MessageBox.Show("Voulez-vous Vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                       //pour supprimer toutes les client selectionner
                    for (int i = 0; i < DgvClient.Rows.Count; i++)
                    {
                        if ((bool)DgvClient.Rows[i].Cells[0].Value == true)
                        {
                            cLS_Client.suprimer_Client(int.Parse(DgvClient.Rows[i].Cells[i].Value.ToString()));
                        }
                    }
                    //actualise datagridview
                    Actualisedatagrid();
                    MessageBox.Show("Suppresion avec succées", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppresion et annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Recherche")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = Color.Black;
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listerecherche=db.Clients.ToList();//listerecherche = liste client
            if (txtRechercher.Text != "")
            {
                switch(comboRecherche.Text)
                {
                    //    
                    case "Nom":
                        listerecherche =listerecherche.Where(s=>s.Nom_Client.IndexOf(txtRechercher.Text,StringComparison.CurrentCultureIgnoreCase)!= -1).ToList(); 
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephonne_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                }
            }
            //vider datagridview
            DgvClient.Rows.Clear();
            //ajouter list recherche dans datagridview client
            foreach(var l in listerecherche)
            {
                DgvClient.Rows.Add(false, l.ID_CLIENT, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephonne_Client, l.Email_Client, l.Ville_Client, l.Pays_Client);
            }
        }

        private void DgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRechercher.Enabled = true;
            txtRechercher.Text = "";
        }
    }
}
