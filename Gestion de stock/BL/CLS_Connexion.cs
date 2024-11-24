using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_stock.BL
{
    internal class CLS_Connexion
    {
            //POUR VERIFIER LA CONNEXION
            public bool ConnexionValide(DbStockContext db, String Nom, String Mot_de_passe)
            {
                Utilisateur U = new Utilisateur();
                U.NomUtilisateur= Nom;  
                U.Mot_De_Passe= Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s =>s.NomUtilisateur==Nom && s.Mot_De_Passe==Mot_de_passe  )!=null)// SI LE NOM ET LE MOT DE PASSE EXISTE DANS LA BASE DE DONNE
            {
                return  true;
            }
            else // SI NON existe
            {
                return false;  
            }
        }
    }
}
