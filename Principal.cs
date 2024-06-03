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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        #region "Variables"
        int esta_guardada = 0;
        int n_codigo = 0; //Se utiliza para guardar el codigo seleccionado
        #endregion

        #region "Mis Metodos"
        #endregion

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            {
                // esta_guardada representa la opcion 1 del procedimiento almacenado lo que significa que ingresara datos y no actualizara
                
                esta_guardada = 1;

                if (string.IsNullOrEmpty(txt_Nombre.Text)) 
                {
                    MessageBox.Show("Este campo no puede estar vacio", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string respuesta = "";
                    E_Empleado empleado = new E_Empleado();
                    empleado.id_empleado =  n_codigo;

                    empleado.nombre = txt_Nombre.Text.Trim();
                    empleado.apellido=  txt_Apellido.Text.Trim();
                    empleado.cedula = txt_Cedula.Text.Trim();
                    empleado.usuario=  Login.usuario;

                    respuesta = N_Empleado.insertar_empleado(esta_guardada, empleado);
                    if (respuesta == "Ok")
                    {
                        MessageBox.Show("Datos guardados correctamente.", "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                        esta_guardada = 0;
                        n_codigo = 0;

                        txt_Nombre.Text = "";

                        txt_Apellido.Text = "";

                        txt_Cedula.Text = "";

                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }
      
        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        
        
       
        private void btn_Reporte_Click(object sender, EventArgs e)
        {

            F_REPORTE_EMPLEADO frm_reporte_empleado = new F_REPORTE_EMPLEADO();
        }

        
    }
    }
