//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_de_stock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details_Commande
    {
        public int IdDetail { get; set; }
        public int Id_Commande { get; set; }
        public int Id_produit { get; set; }
        public string Nom_Produit { get; set; }
        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string Remise { get; set; }
        public string ToTal { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }
}