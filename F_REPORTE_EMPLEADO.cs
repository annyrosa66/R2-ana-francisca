using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class F_REPORTE_EMPLEADO : Form
    {
        public F_REPORTE_EMPLEADO()
        {
            InitializeComponent();
        }

        private void F_REPORTE_EMPLEADO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.selet_empleado1' Puede moverla o quitarla según sea necesario.
            this.selet_empleado1TableAdapter.Fill(this.dataSet1.selet_empleado1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
