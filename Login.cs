using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {


        E_user objeuser = new E_user();
        N_users objnuser = new N_users();
        Principal frm = new Principal();

        public static string usuario;


        public void Iniciar()
        {
            DataTable dt = new DataTable();
            objeuser.usuario= txt_usuario.Text;
            objeuser.contraseña=txt_pass.Text;
            dt = objnuser.N_user(objeuser);
            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("BIENVENIDO  "+ dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = dt.Rows[0][0].ToString();

                //0 0 representa el orden del campo en el procedimiento almacenado de seleccionar

                frm.ShowDialog();
                Login login = new Login();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                Close();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public Login()
        {
            InitializeComponent();
        }





        private void Frm_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }



}
