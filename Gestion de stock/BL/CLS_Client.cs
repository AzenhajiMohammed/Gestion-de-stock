using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Gestion_de_stock.BL
{
    internal class CLS_Client
    {
        private DbStockContext db= new DbStockContext();
        private Client C;//TABLE CLIENT
        //FONCTION POUR AJOUTER LES DONNES DANS LA TABLE CLIENT

        public bool Ajouter_Client(string Nom,string Prenom,string Adresse,string Telephone,string Email,string Pays,string Ville)
        {
            C= new Client();//nvl client
            C.Nom_Client= Nom;
            C.Prenom_Client= Prenom;
            C.Adresse_Client= Adresse;
            C.Telephonne_Client= Telephone;
            C.Email_Client= Email;
            C.Pays_Client= Pays;
            C.Ville_Client= Ville;
            //verification cest les donne deja exite
            if (db.Clients.SingleOrDefault (s=>s.Nom_Client==Nom && C.Prenom_Client==Prenom)==null)
            {
                db.Clients.Add(C);//ajouter dans la table client
                db.SaveChanges();//enregistrer
                return true;
            }else
            {
                return false;
            }

        }

        // fonction pour modifier les client dans la base de donne
        public void Modifier_Client (int id,string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {
            C=new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_CLIENT == id);//verifier si id de client et existe
            if (C!=null)
            {
                C.Nom_Client = Nom;
                C.Prenom_Client = Prenom;
                C.Adresse_Client = Adresse;
                C.Telephonne_Client = Telephone;
                C.Email_Client = Email;
                C.Pays_Client = Pays;
                C.Ville_Client = Ville;
                db.SaveChanges ();
            }
        }
        //foction pour supprimmer client
        public void suprimer_Client(int id)
        {
            C= new Client();
            C= db.Clients.SingleOrDefault(c => c.ID_CLIENT == id); 
            if (C!=null)//existe
            {
                db.Clients.Remove(C);//pour supprimer le client
                db.SaveChanges() ;
            }
        }
    }
}
