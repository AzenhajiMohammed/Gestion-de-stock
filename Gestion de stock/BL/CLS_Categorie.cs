using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_stock.BL
{
    internal class CLS_Categorie
    {
        private DbStockContext db = new DbStockContext();
        private Categorie cat;
        //fonction ajouter categorie
        public bool Ajouter_categorie(string NomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie=NomCat;
            if(db.Categories.SingleOrDefault(s=> s.Nom_Categorie == NomCat) == null)
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else//si le nom categorie existe deja
            {
                return false;
            }

        }
        //modifier categorie
        public void Modifier_Categorie(int idcat, string NomCat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s=>s.ID_CATEGORIE == idcat);
            if (cat != null)
            {
                cat.Nom_Categorie = NomCat;
                db.SaveChanges();
            }
            
        }
        public void Supprimer_Categorie(int idcat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s=>s.ID_CATEGORIE==idcat);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
            
        }

    }
}
