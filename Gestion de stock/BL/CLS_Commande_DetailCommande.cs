using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_stock.BL
{
    internal class CLS_Commande_DetailCommande
    {
        private DbStockContext db=new DbStockContext();
        private Commande clscmd;
        private Details_Commande clsd;
        public int IDCommande;
        //sauvgarder commande
        public void Ajouter_Commande(DateTime dateCommande,int Idclient,string totalht,string tva,string totalttc)
        {
            clscmd = new Commande();
            clscmd.DATE_Commande = dateCommande;
            clscmd.ID_Client = Idclient;
            clscmd.ToTal_HT = totalht;
            clscmd.TVA = tva;
            clscmd.ToTal_TTC = totalttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            IDCommande = clscmd.ID_Commande;

        }
        
        public void Ajouter_Detail(int idproduit,string Nomproduit,int quantite,string prix,string remis,string total)
        {
            clsd = new Details_Commande();
            clsd.Id_Commande = IDCommande;
            clsd.Id_produit = idproduit;
            clsd.Nom_Produit=Nomproduit;
            clsd.Quantite = quantite;
            clsd.Prix = prix;
            clsd.Remise = remis;
            clsd.ToTal = total;
            db.Details_Commande.Add(clsd);
            db.SaveChanges();
        }
    }
}
