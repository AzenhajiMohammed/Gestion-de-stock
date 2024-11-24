using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Reporting.WinForms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Office.Interop.Excel;

namespace Gestion_de_stock.PL
{
    public partial class User_List_Produit : UserControl
    {
        private static User_List_Produit UserClient;
        private DbStockContext db;
        //creer un instance pour usercontrole
        public static User_List_Produit Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new User_List_Produit();
                }
                return UserClient;
            }

        }
        public User_List_Produit()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        //actualiser datagrid produit
        public void ActualiserDgv()
        {
            db=new DbStockContext();
            DgvProduit.Rows.Clear();
            // pour afficher le nom de categorie a partie de idcategorie
            Categorie Cat = new Categorie();
            foreach(var lis in db.Produits)
            {
                Cat=db.Categories.SingleOrDefault(s=>s.ID_CATEGORIE == lis.ID_CATEGORIE);
                if(Cat!=null)
                {
                    DgvProduit.Rows.Add(false,lis.Id_produit,lis.Nom_Produit,lis.Quantite_Produit,lis.Prix_Produit,Cat.Nom_Categorie);
                }
            }
            //colorer stock vide en rouge
            for (int i = 0;i<DgvProduit.Rows.Count;i++)
            {
                if ((int)DgvProduit.Rows[i].Cells[3].Value == 0)//si stock ==0
                {
                    DgvProduit.Rows[i].Cells[3].Style.BackColor=Color.Red;
                }
                else
                {
                    DgvProduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
            }
        }
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < DgvProduit.Rows.Count; i++)
            {
                if ((bool)DgvProduit.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
                if (Nombreligneselect == 0)
                {
                    return "Selectionner le Produit";
                }
                if (Nombreligneselect > 1)
                {
                    return "Selectionner seulment 1 seul Produit";
                }


            }
            return null;
        }



        private void User_List_Produit_Load(object sender, EventArgs e)
        {
            ActualiserDgv();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Recherche")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = Color.Black;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Produit PR=new Produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmproduit.LblTitre.Text = "Modifier Produit";
                for (int i = 0; i < DgvProduit.Rows.Count; i++)//verif les ligne selectinner
                {
                    if ((bool)DgvProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)DgvProduit.Rows[i].Cells[1].Value;//MYIDSELECT = id de ligne selectionner
                        PR = db.Produits.SingleOrDefault(s => s.Id_produit== MYIDSELECT);//verifier si id de produit = id selectionner dans datagridview
                        if (PR != null)
                        {
                            frmproduit.comboCategorie.Text = DgvProduit.Rows[i].Cells[5].Value.ToString();
                            frmproduit.txtNomP.Text = DgvProduit.Rows[i].Cells[2].Value.ToString();
                            frmproduit.txtquantiteP.Text = DgvProduit.Rows[i].Cells[3].Value.ToString();
                            frmproduit.txtPrixP.Text = DgvProduit.Rows[i].Cells[4].Value.ToString();
                            frmproduit.IDPRODUIT = (int)DgvProduit.Rows[i].Cells[1].Value;
                            //afficher limage de produit pour modifier
                            MemoryStream MS = new MemoryStream(PR.Image_Produit);
                            frmproduit.picProduit.Image = System.Drawing.Image.FromStream(MS);
                        }


                        
                    }
                }
                        frmproduit.btnActualiser.Visible = false;
            frmproduit.ShowDialog();
            }
           
        }

        private void BtnAfficherPhoto_Click(object sender, EventArgs e)
        {
            Produit PR= new Produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(),"Selectionner",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0;i<DgvProduit.Rows.Count;i++)//verif les ligne selectinner
                {
                    if ((bool)DgvProduit.Rows[i].Cells[0].Value==true)
                    {
                        int MYIDSELECT=(int)DgvProduit.Rows[i].Cells[1].Value;//MYIDSELECT = id de ligne selectionner
                        PR=db.Produits.SingleOrDefault(s=>s.Id_produit==MYIDSELECT);//verifier si id de produit = id selectionner dans datagridview
                        if (PR != null)
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            MemoryStream MS= new MemoryStream(PR.Image_Produit);//pour convertir limage de produit
                            frmP.ProduitImage.Image=System.Drawing.Image.FromStream(MS);
                            frmP.ProduitNom.Text = DgvProduit.Rows[i].Cells[2].Value.ToString();
                            //afficher formulaire
                            frmP.ShowDialog();
                        }
                    }
                }
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (SelectVerif() == "Selectionner le Produit")
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulea-vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //verifier combien ligne selectionner
                if (DR == DialogResult.Yes)
                {

                    for (int i = 0; i < DgvProduit.Rows.Count; i++)
                    {
                        if ((bool)DgvProduit.Rows[i].Cells[0].Value == true)
                        {
                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)DgvProduit.Rows[i].Cells[1].Value;
                            clproduit.Supprimer_Produit(idselect);
                        }
                    }
                
                     //actualiser datagridview
                     ActualiserDgv();
                     MessageBox.Show("Produit supprimer avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression est annule", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        
            
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listerecherche = db.Produits.ToList();//listerecherche = liste client
              
                    //recherche seulment par nom de produit
        listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtRechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                      
            //vider datagridview
            DgvProduit.Rows.Clear();
            //ajouter list recherche dans datagridview client
            Categorie cat = new Categorie();
            foreach (var l in listerecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == l.ID_CATEGORIE);
                DgvProduit.Rows.Add(false,l.Id_produit,l.Nom_Produit,l.Quantite_Produit,l.Prix_Produit,cat.Nom_Categorie);
            }   
        }

        private void btnImprimerSelect_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            int idselect=0;
            string Nomcategorie=null;
            RAP.FRM_RAPPORT frmrpt = new RAP.FRM_RAPPORT();
            Produit PR = new Produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(),"Imprimer Produit",MessageBoxButtons.OK,MessageBoxIcon.Error);//veridier si lutulisateur cocher plusieur ligne
            }
            else
            {
                for(int i = 0;i<DgvProduit.Rows.Count;i++)
                {
                    if ((bool)DgvProduit.Rows[i].Cells[0].Value == true)
                    {
                        idselect=(int) DgvProduit.Rows [i].Cells[1].Value;
                        Nomcategorie = DgvProduit.Rows[i].Cells[5].Value.ToString();
                    } 
                    PR = db.Produits.SingleOrDefault(s=> s.Id_produit==idselect);
                    if (PR != null )//si le produit existe
                    {
                        try
                        {
                            
                            frmrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "Users.simo.source.repos.Gestion de stock.RAP.RPT_Produit.rdlc";
                            ReportParameter Pcategorie = new ReportParameter("RPCategorie", Nomcategorie);//nom de categorie
                            ReportParameter PNom = new ReportParameter("RPNom", PR.Nom_Produit);
                            ReportParameter PQuantite = new ReportParameter("RPQuantité", PR.Quantite_Produit.ToString());
                            ReportParameter PPrix = new ReportParameter("RPPrix", PR.Prix_Produit);
                            string ImageString = Convert.ToBase64String(PR.Image_Produit);
                            ReportParameter Pimage = new ReportParameter("RPImage", ImageString);
                            //souvgarder les nouveau parametre dans la rapport
                            frmrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, PNom, PQuantite, PPrix, Pimage });
                            frmrpt.RPAfficher.RefreshReport();
                            frmrpt.ShowDialog();//afficher formulaire de rapport
                        }
                        catch (Exception EX)
                        {
                            MessageBox.Show(EX.Message);
                        }

                    }
                }
            }
        }

        private void btnImprimerTout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORT frrpt=new RAP.FRM_RAPPORT();
            db = new DbStockContext();
            try
            {
            var listeProduit=db.Produits.ToList();//liste des produit
            frrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "Users.simo.source.repos.Gestion de stock.RAP.RPT_Liste_Produit.rdlc";
            frrpt.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("databaseproduit", listeProduit));
            ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
            frrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date });
            frrpt.RPAfficher.RefreshReport();
            frrpt.ShowDialog();
            }catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true }) //Filter seulment fichier Exel
            {
                if(SFD.ShowDialog()== DialogResult.OK) 
                { 
                
                    Microsoft.Office.Interop.Excel.Application app= new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantite";
                    ws.Cells[1, 4] = "Prix";
                       
                    //ajouter liste de produit de base de donne dans fichier exel
                    var ListeProduit = db.Produits.ToList();//listes des produit
                    int i = 2;
                    foreach(var L in ListeProduit)
                    {   
                        ws.Cells[i,1]=L.Id_produit;
                        ws.Cells[i,2] = L.Nom_Produit;
                        ws.Cells[i,3] = L.Quantite_Produit;
                        ws.Cells[i,4] = L.Prix_Produit;
                    i++;
                    }
                    //changer style de fichier--------
                    ws.Range["A1:D1"].Interior.Color = Color.Teal;//bahground color
                    ws.Range["A1:D1"].Font.Color = Color.White;
                    ws.Range["A1:D1"].Font.Size = 16;//text size
                    ws.Range["A:D"].HorizontalAlignment= XlHAlign.xlHAlignCenter;
                    ws.Range["A1:D1"].ColumnWidth = 17;// change column size
                  //-----------------------------
                  wb.SaveAs(SFD.FileName);//SOUVGARDER DANS FICHIER EXEL
                    app.Quit();
                    MessageBox.Show("Souvgarde avec succees dans Exel","Exel",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void DgvProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualiserDgv();
        }

        private void txtRechercher_Leave(object sender, EventArgs e)
        {

        }
    }
}
