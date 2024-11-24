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

namespace Gestion_de_stock.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private DbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl user)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.userProduit = user;
            //Afficher les categorie dans comoboxcategorie
            comboCategorie.DataSource = db.Categories.ToList();
            comboCategorie.DisplayMember = "Nom_Categorie";
            comboCategorie.ValueMember= "ID_CATEGORIE";
        }
        //champ obligatoire
        string testobligatoire()
        {
            if(txtNomP.Text== "Nom Produit" || txtNomP.Text == "")
            {
                return "Entrer le Nom Produit";
            }
            if(txtquantiteP.Text== "Quantité" || txtquantiteP.Text == "")
            {
                return "Entrer Quantité";
            }
            if (txtPrixP.Text == "Prix" || txtPrixP.Text == "")
            {
                return "Entrer Prix";
            }
            if(picProduit.Image==null)
            {
                return "Entrer l'image de produit";
            }
            if (comboCategorie.Text == "")
            {
                return "Entrer Categorie";
            }
            return null;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomP_Enter(object sender, EventArgs e)
        {
            if (txtNomP.Text == "Nom Produit")
            {
                txtNomP.Text= "";
                txtNomP.ForeColor = Color.White;
            }
        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {
            if (txtNomP.Text == "")
            {
                txtNomP.Text = "Nom Produit";
                txtNomP.ForeColor = Color.Silver;
            }
        }

        private void txtquantiteP_Enter(object sender, EventArgs e)
        {
            if (txtquantiteP.Text == "Quantité")
            {
                txtquantiteP.Text = "";
                txtquantiteP.ForeColor = Color.White;
            }
        }

        private void txtquantiteP_Leave(object sender, EventArgs e)
        {
            if (txtquantiteP.Text == "")
            {
                txtquantiteP.Text = "Quantité";
                txtquantiteP.ForeColor = Color.Silver;
            }
        }

        private void txtPrixP_Enter(object sender, EventArgs e)
        {
            
                if (txtPrixP.Text == "Prix")
            {
                txtPrixP.Text = "";
                txtPrixP.ForeColor = Color.White;
            }
        }

        private void txtPrixP_Leave(object sender, EventArgs e)
        {
            if (txtPrixP.Text == "")
            {
                txtPrixP.Text = "Prix";
                txtPrixP.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP=new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";//POUR AFFICHER SEULMMENT LES IMAGES
            if(OP.ShowDialog() == DialogResult.OK)
            {
                picProduit.Image=Image.FromFile(OP.FileName);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtNomP.Text = "Nom Produit";txtNomP.ForeColor = Color.Silver;
            txtquantiteP.Text = "Quantité";txtquantiteP.ForeColor = Color.Silver;
            txtPrixP.Text="Prix"; txtPrixP.ForeColor = Color.Silver;
            comboCategorie.Text = "";
            picProduit.Image=null;
        }

        private void txtPrixP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtquantiteP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void FRM_Ajouter_Modifier_Produit_Load(object sender, EventArgs e)
        {

        }
        public int IDPRODUIT;
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        { 
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(LblTitre.Text=="Ajouter Produit")
                {
                    BL.CLS_Produit cL_Produit = new BL.CLS_Produit();
                    //convertire image en format byte
                    MemoryStream MR= new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                        byte[]byteimageP =  MR.ToArray();

                    if (cL_Produit.Ajouter_Produit(txtNomP.Text, int.Parse(txtquantiteP.Text), txtPrixP.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajouter avec succes", "Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        (userProduit as User_List_Produit).ActualiserDgv();
                    }
                    else
                    {
                        MessageBox.Show("Produit Existe D'éja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    

                    
                }
                else
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    BL.CLS_Produit clsproduit= new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez-vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                     clsproduit.modifier_Produit(IDPRODUIT, txtNomP.Text, int.Parse(txtquantiteP.Text), txtPrixP.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue));
                        MessageBox.Show("Produit Modifier avec succes","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        (userProduit as User_List_Produit).ActualiserDgv();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Modification annule", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
