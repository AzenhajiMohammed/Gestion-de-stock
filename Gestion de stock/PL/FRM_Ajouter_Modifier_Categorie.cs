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
    
    public partial class FRM_Ajouter_Modifier_Categorie : Form
    {
        private UserControl usercat;
        public FRM_Ajouter_Modifier_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom de Categorie")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom de Categorie";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int idcategorie;
        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if (txtNom.Text == "" || txtNom.Text == "Nom de Categorie")
            {
                MessageBox.Show("Entrer Nom de Categorie", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lblTitre.Text== "Ajouter Categorie")
                {
                    if (clcat.Ajouter_categorie(txtNom.Text) == false)
                    {
                        MessageBox.Show("Categorie existe d'eja", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Categorie ajouter avec succes", "Ajouter categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }
                }
                if (lblTitre.Text == "Modifier Categorie")
                {
                    DialogResult DR = MessageBox.Show("Voulez-vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        clcat.Modifier_Categorie(idcategorie, txtNom.Text);
                        MessageBox.Show("Categorie Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //actualiser dgv
                        (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Modification anulle", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FRM_Ajouter_Modifier_Categorie_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Enter_1(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom de Categorie")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtNom_Leave_1(object sender, EventArgs e)
        { 
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom de Categorie";
                txtNom.ForeColor = Color.Silver;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
