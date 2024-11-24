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
    public partial class User_Liste_Commande : UserControl
    {
        private static User_Liste_Commande UserCommande;
        private DbStockContext db;
        //creer un ustance pour le usercontrol
        public static User_Liste_Commande Instance
        {
            get
            {
                if(UserCommande == null)
                {
                    UserCommande=new User_Liste_Commande();
                }
                return UserCommande ;
            }
        }
        public User_Liste_Commande()
        {
            InitializeComponent();
            db = new DbStockContext();

        }
        //remplir  datagrid commande
        public void Remplirdata()
        {
            dgvcommande.Rows.Clear();
            Client c= new Client();
            string NomPrenom;
            foreach(var LC in db.Commandes)
            {
                //afficher nom+prenom de client
                c = db.Clients.Single(s => s.ID_CLIENT == LC.ID_Client);
                NomPrenom=c.Nom_Client+" "+ c.Prenom_Client;
                dgvcommande.Rows.Add(LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.ToTal_HT, LC.TVA, LC.ToTal_TTC);
            }
        }

        private void User_Liste_Commande_Load(object sender, EventArgs e)
        {
            Remplirdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RECHERCHE ENTRE DEUX DATE
            var listecommande=db.Commandes.ToList();// lister les commande
            if (dgvcommande.Rows.Count != 0)
            {
                listecommande =listecommande.Where(s=>s.DATE_Commande.Date>=dateD.Value.Date && s.DATE_Commande.Date<=dateF.Value.Date).ToList();
                //remplir datagrid
                dgvcommande.Rows.Clear();
                Client c = new Client();
                string NomPrenom;
                foreach (var LC in listecommande)
                {
                    //afficher nom+prenom de client
                    c = db.Clients.Single(s => s.ID_CLIENT == LC.ID_Client);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dgvcommande.Rows.Add(LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.ToTal_HT, LC.TVA, LC.ToTal_TTC);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_Detail_Commande frnC= new PL.FRM_Detail_Commande(this);
            frnC.ShowDialog();
        }
    }
}
