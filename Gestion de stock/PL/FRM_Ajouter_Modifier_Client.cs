using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Gestion_de_stock.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC ;
        }
        string testObligatoire()
        {
            if (TxtNom.Text == "" || TxtNom.Text == "Nom de Client")
            {
                return "Entrer le Nom de Client ";
            }
            if (txtPrenom.Text==""||  txtPrenom.Text == "Prenom de Client")
            {
                return "Entrer le Prenom de Client";
            }
            if (txtAdresse.Text=="" || txtAdresse.Text == "Adresse Client")
            {
                return "Entrer le Adresse Client";
            }
            if (txtTelephone.Text=="" || txtTelephone.Text == "Telephone Client")
            {
                return "Enter le Telephone Client";
            }
            if(txtEmail.Text==""|| txtEmail.Text == "Email Client")
            {
                return "Enter le Email Client";
            }
            if(txtPays.Text==""|| txtPays.Text == "Pays Client")
            {
                return "Enter le Pays Client";
            }
            if (txtVille.Text == "" || txtVille.Text == "Ville Client")
            {
                return "Enter le Ville Client";
            }
            if (txtEmail.Text != "" || txtEmail.Text != "Email Client")
            {
                try
                {
                    new MailAddress(txtEmail.Text);//verifier l'email
                }
                catch(Exception e) 
                {
                    return "Email Invalide";
                }
            }


                return null;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNom_Enter(object sender, EventArgs e)
        {
            if(TxtNom.Text== "Nom de Client")
            {
                TxtNom.Text = "";
                TxtNom.ForeColor = Color.White;
            }
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
            if (TxtNom.Text == "")
            {
                TxtNom.Text = "Nom de Client";
                TxtNom.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prenom de Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.White;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prenom de Client";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse Client")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse Client";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void txtTelephone_Enter(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "Telephone Client")
            {
                txtTelephone.Text = "";
                txtTelephone.ForeColor = Color.White;
            }
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                txtTelephone.Text = "Telephone Client";
                txtTelephone.ForeColor = Color.Silver;
            }
        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            if (txtPays.Text == "Pays Client")
            {
                txtPays.Text = "";
                txtPays.ForeColor = Color.White;
            }
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            if (txtPays.Text == "")
            {
                txtPays.Text = "Pays Client";
                txtPays.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
        if (txtEmail.Text == "Email Client")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email Client";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            if (txtVille.Text == "Ville Client")
            {
                txtVille.Text = "";
                txtVille.ForeColor = Color.White;
            }
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (txtVille.Text == "")
            {
                txtVille.Text = "Ville Client";
                txtVille.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled= false;
            }
        }

        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
        public int IdSelect;

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testObligatoire()!= null)
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (LblTitre.Text == "Ajouter Client")

     
            {
                BL.CLS_Client clClient = new BL.CLS_Client();
                if (clClient.Ajouter_Client(TxtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTelephone.Text, txtEmail.Text, txtPays.Text, txtVille.Text) == true)
                {
                    MessageBox.Show("Client Ajouter avec succes","Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (usclient as User_Liste_Client).Actualisedatagrid();

                }
                else
                {
                    MessageBox.Show("Nom et Prenom de client déjà existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                BL.CLS_Client clclient= new BL.CLS_Client();
                
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier Le Client","Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                if (R== DialogResult.Yes)
                {
                    clclient.Modifier_Client(IdSelect, TxtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTelephone.Text, txtEmail.Text, txtPays.Text, txtVille.Text);
                
                //pour actualise datagridviw
                (usclient as User_Liste_Client).Actualisedatagrid();
                MessageBox.Show("Client Modifier avec succes","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("modification est annule","Modification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //valider les textbox
            TxtNom.Text = "";TxtNom.ForeColor = Color.Silver;
            txtPrenom.Text = "";txtPrenom.ForeColor = Color.Silver;
            txtAdresse.Text = "";txtAdresse.ForeColor = Color.Silver;
            txtTelephone.Text = ""; txtTelephone.ForeColor = Color.Silver;
            txtEmail.Text = "";txtEmail.ForeColor = Color.Silver;
            txtPays.Text = "";txtPays.ForeColor = Color.Silver;
            txtVille.Text = "";txtVille.ForeColor = Color.Silver;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
