using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_stock.BL
{
    internal class CLS_Produit
    {
        private DbStockContext db=new DbStockContext();
        private Produit PR;
        //AJOUTER PRODUIT
        public bool Ajouter_Produit( string NomP,int quantite,string prix,byte[] imageP,int IdCategorie)
        {
            PR = new Produit();
            PR.Nom_Produit=NomP;
            PR.Quantite_Produit = quantite;
            PR.Prix_Produit = prix;
            PR.Image_Produit = imageP;
            PR.ID_CATEGORIE = IdCategorie;
            //verifier cest le produit deja existe
            if(db.Produits.SingleOrDefault(a=>a.Nom_Produit==NomP) == null )
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        //modifier produit
        public void modifier_Produit(int IDP,string NomP, int quantite, string prix, byte[] imageP, int IdCategorie)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.Id_produit == IDP);
            if(PR != null)
            {
                PR.Nom_Produit = NomP;
                PR.Quantite_Produit=quantite;
                PR.Prix_Produit=prix;
                PR.Image_Produit=imageP;
                PR.ID_CATEGORIE=IdCategorie;
                db.SaveChanges();
            }
        }
        //supprimer produit
        public void Supprimer_Produit(int id)
        {
            PR=new Produit();
            PR=db.Produits.SingleOrDefault(s=>s.Id_produit==id);
            if(PR != null)
            {
                db.Produits.Remove(PR);
                db.SaveChanges();
            }
        }

        
    }
}
