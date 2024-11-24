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
    public partial class frm_connexion : Form
    {
        private const string V = "";

        private DbStockContext Db;
        private Form frmMenu;
        //class connxion
        BL.CLS_Connexion C =    new BL.CLS_Connexion();
        public frm_connexion(Form Menu)
        {
            InitializeComponent();
            this.frmMenu=Menu;
            //initialiser la base de donne
            Db= new DbStockContext();
        } 

        private void frm_connexion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TestObligatoire()== null)
            {
               if (C.ConnexionValide(Db,txtNom.Text,textmotdepasse.Text)==true)// utilisateur existe
                {
                    MessageBox.Show("Connecion a reussi","Connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (frmMenu as FRM_Menu).activerFrm();
                    this.Close();//CONNEXION REUSITE
                }
                else
                {
                    MessageBox.Show("Connexion a echoue", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(TestObligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //POUR VERIFIER LES CAMP OBLIGATOIRE
        string TestObligatoire()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom d'utilisateur")
            {
                return "Enter votre nom";
            }
            if (textmotdepasse.Text == "" || textmotdepasse.Text== "Mot de passe")
            {
                return "Enter votre mot de passe";
            }
            return null;
        }
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textmotdepasse_Enter(object sender, EventArgs e)
        {
            if (textmotdepasse.Text == "Mot de passe")
            {
                textmotdepasse.Text = "";
                textmotdepasse.UseSystemPasswordChar = false;
                textmotdepasse.PasswordChar = '*';
                textmotdepasse.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textmotdepasse_Leave(object sender, EventArgs e)
        {
            if (textmotdepasse.Text == "")
            { 
                 
                textmotdepasse.Text = "Mot de passe";
                textmotdepasse.UseSystemPasswordChar = true;
                textmotdepasse.ForeColor = Color.Silver;
            }
        }

        private void button1_Leave(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
