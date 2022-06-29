using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;
namespace ACADEMIA_SER
{
    public partial class FrmSesionDeClases : Form
    {
        public FrmSesionDeClases()
        {
            InitializeComponent();
            listarSesion();
        }

        public void listarSesion()
        {
            DgwSesion.DataSource = LogSesionDeClases.Instancia.ListarSesion();
        }
        public void limpiar()
        {
            txtSesionId.Text = "";
            txtAreaID.Text = "";
            txtSilabo_id.Text = "";

        }
        private void FrmSesionDeClases_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntSesionDeClase ses = new EntSesionDeClase();
                ses.fecha = Convert.ToDateTime(dateTimePicker1.Value);
                ses.sesionDeclase_id = int.Parse(txtSesionId.Text.Trim());
                ses.reprogramacion = Convert.ToDateTime(dateTimePicker2.Value);
                ses.area_id = int.Parse(txtAreaID.Text.Trim());
                ses.silabo_id = int.Parse(txtSilabo_id.Text.Trim());
                LogSesionDeClases.Instancia.InsertarSesion(ses);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiar();
            listarSesion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EntSesionDeClase ses = new EntSesionDeClase();
                ses.sesionDeclase_id = int.Parse(txtSesionId.Text.Trim());
                ses.reprogramacion = Convert.ToDateTime(dateTimePicker2.Value);
                LogSesionDeClases.Instancia.ActualizarSesion(ses);
                MessageBox.Show(" se hizo la reprogramacion a" + dateTimePicker2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiar();
            listarSesion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
