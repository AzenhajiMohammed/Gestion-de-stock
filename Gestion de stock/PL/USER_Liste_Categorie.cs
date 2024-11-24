using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics.Eventing.Reader;

namespace Gestion_de_stock.PL
{
    public partial class USER_Liste_Categorie : UserControl
    
    {
        private static USER_Liste_Categorie usercategorie;
        private DbStockContext db;
        public static USER_Liste_Categorie Instance
        {
            get
            {
                if (usercategorie == null)
                {
                    usercategorie =new USER_Liste_Categorie();
                }
                return usercategorie;
            }
            
        }
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < DgvCategorie.Rows.Count; i++)
            {
                if ((bool)DgvCategorie.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
                if (Nombreligneselect == 0)
                {
                    return "Selectionner Categorie";
                }
                if (Nombreligneselect > 1)
                {
                    return "Selectionner seulmment 1 Categorie";
                }


            }
            return null;
        }
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db= new DbStockContext();
            
        }
        public void remplirdatagrid()//remplire datagridview
        {
            db= new DbStockContext();
            DgvCategorie.Rows.Clear();
            foreach(var Cat in db.Categories)
            {
                DgvCategorie.Rows.Add(false, Cat.ID_CATEGORIE, Cat.Nom_Categorie);
            }
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void txtRechercher_Enter(object sender, EventArgs e)
        {

        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            var maliste = db.Categories.ToList();
            maliste = maliste.Where(s=>s.Nom_Categorie.IndexOf(txtRechercher.Text,StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
            DgvCategorie.Rows.Clear();
            foreach(var l in maliste)
            {
                DgvCategorie.Rows.Add(false,l.ID_CATEGORIE,l.Nom_Categorie);
            }

            
        }

        private void DgvCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            if (DgvCategorie.Columns[e.ColumnIndex].Name== "Modifier")// if i click on modifier
            {
                //id de categorie
                frmcat.idcategorie = (int)DgvCategorie.Rows[e.RowIndex].Cells[1].Value;
                //afficher Nom de categorie dans formulaire pour modifier
               
                frmcat.lblTitre.Text = "Modifier Categorie";
                frmcat.txtNom.Text = DgvCategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.ShowDialog();
            }
            //Supprimer Categorie
            if (DgvCategorie.Columns[e.ColumnIndex].Name== "Supprimer")
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult PR=MessageBox.Show("Voulez-vous vraiment supprimer categorie","Suppresion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    //verifier si il y a des produit dans cette categorie
                    int idcat = (int)DgvCategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_CATEGORIE == idcat);//count = combien produit dans categorie
                    if(P==0)//aucun produit dans cette categorie
                    {
                        clscat.Supprimer_Categorie(idcat);
                        MessageBox.Show("Categorie supprimer aves succes","suppresion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        //il ya des produit dans cette categorie
                        DialogResult PDP = MessageBox.Show("il y a " + P + " Produit dans cette categorie Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (PDP == DialogResult.Yes)
                        {
                            clscat.Supprimer_Categorie(idcat);
                            MessageBox.Show("Categorie supprimer aves succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("suppresion anuuler", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void txtRechercher_Enter_1(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Recherche")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = Color.Black;
            }
        }

        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "")
            {
                txtRechercher.Text = "Recherche";
                txtRechercher.ForeColor = Color.Silver;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Categorie frmcat = new PL.FRM_Ajouter_Modifier_Categorie(this);
            frmcat.ShowDialog();
        }

        private void btnImprimerTout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORT frmR = new RAP.FRM_RAPPORT();
            db = new DbStockContext();
            try
            {
                //liste Categories
                var listeCat = db.Categories.ToList();
                //Nombre de categorie
                int NBcategorie = db.Categories.Count();
                //Ajouter Datasource
                frmR.RPAfficher.LocalReport.ReportEmbeddedResource = "C:\\Users\\simoh\\source\\repos\\Gestion de stock\\Gestion de stock\\RAP\\RPT_Liste_Categorie.rdlc";
                frmR.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("DataBaseCategorie", listeCat));
                //date de systeme
                ReportParameter date=new ReportParameter("Date",DateTime.Now.ToShortDateString());
                //nombre categorie
                ReportParameter nbC = new ReportParameter("NBCategorie", NBcategorie.ToString());
                frmR.RPAfficher.LocalReport.SetParameters(new ReportParameter[] {date, nbC});
                frmR.RPAfficher.RefreshReport();
                frmR.ShowDialog();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            string NomCategorie = "";

            int idcategorie = 0;

            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(),"Selectionner",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {

            
                 using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workbook|*xlsx",ValidateNames = true})
                 {
                    if(sf.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application APP = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = APP.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)APP.ActiveSheet;
                        APP.Visible = false;
                        //Nom Categorie et id categorie
                        for(int j = 0; j < DgvCategorie.Rows.Count; j++)
                        {
                            if ((bool)DgvCategorie.Rows[j].Cells[0].Value==true)
                            {
                                NomCategorie = DgvCategorie.Rows[j].Cells[2].Value.ToString();
                                idcategorie= (int) DgvCategorie.Rows[j].Cells[1].Value;
                            }
                        }
                        //ecrire nom de categorie dans fichier exel
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value=NomCategorie;
                        //AJOUTER CELLS DE PRODUIT
                        ws.Cells[2, 1] = "Id Produit";
                        ws.Cells[2, 2] = "Nom Produit";
                        ws.Cells[2, 31] = "Quantite";
                        ws.Cells[2, 4] = "Prix";
                        //liste produit dans cette categorie
                        var listeProduit = db.Produits.Where(s => s.ID_CATEGORIE == idcategorie).ToList();
                        int i = 3;
                        foreach(var LP in listeProduit)
                        {
                            ws.Cells[i,1] = LP.Id_produit;
                            ws.Cells[i,2] = LP.Nom_Produit;
                            ws.Cells[i,3] = LP.Quantite_Produit;
                            ws.Cells[i,4] = LP.Prix_Produit;
                        }
                        //style de fichier excel
                        ws.Range["A2:D2"].Interior.Color = Color.Teal;
                        ws.Range["A2:D2"].Font.Color = Color.White;
                        ws.Range["A2:D2"].Font.Size = 15;

                        //categorie
                        ws.Range["A1:D1"].Interior.Color = Color.DarkGreen;
                        ws.Range["A1:D1"].Font.Color = Color.White;
                        ws.Range["A1:D1"].Font.Size = 15;
                        //centre text
                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        ws.Range["A2:D2"].ColumnWidth = 16;
                        //sauvgarder dans exel
                        wb.SaveAs(sf.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false);
                        APP.Quit();
                        MessageBox.Show("Sauvgarder avec succes dans Excel","Excel",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);






                    }
                }
            
            }

        }
    }
}
