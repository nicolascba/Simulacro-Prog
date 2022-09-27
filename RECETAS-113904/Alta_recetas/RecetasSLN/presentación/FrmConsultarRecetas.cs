using RecetasSLN.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        HelperDB helper;
        public FrmConsultarRecetas()
        {
            InitializeComponent();
            helper = new HelperDB();
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            CargarCombo("SP_CONSULTAR_TIPO_RECETA", cboTipoReceta, "tipo_receta", "id_tipo_receta");
        }

        public void CargarCombo(string sp, ComboBox cbo, string display, string value)
        {
            DataTable tabla = helper.ConsultarSQL(sp);
            cbo.DataSource = tabla;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formAgregar agregar = new formAgregar();
            agregar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int tipo = (int)cboTipoReceta.SelectedValue;
            DataTable tabla = helper.ConsultarReceta(tipo, nombre);

            for(int i = 0; i < tabla.Rows.Count; i++)
            {
                string cheff = tabla.Rows[i]["cheff"].ToString();
                dataGridView1.Rows.Add(new object[] { nombre, tipo, cheff });
                cheff = "";
            }

            
        }
    }
}
