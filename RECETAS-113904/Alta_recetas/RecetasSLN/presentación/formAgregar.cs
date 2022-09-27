using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using RecetasSLN.datos;
using RecetasSLN.dominio;

namespace RecetasSLN.presentación
{
    public partial class formAgregar : Form
    {
        HelperDB helper = new HelperDB();
        Receta receta;
        DetalleReceta Detalle;
        public formAgregar()
        {
            InitializeComponent();
            receta = new Receta();
        }

        private void formAgregar_Load(object sender, EventArgs e)
        {                     
            CargarCombos("SP_CONSULTAR_TIPO_RECETA",cboTipo,"tipo_receta","id_tipo_receta");
            CargarCombos("SP_CONSULTAR_INGREDIENTES", cboIngredientes, "n_ingrediente", "id_ingrediente");
            Limpiar();
            ProximoID();
          
        }

        private void CargarCombos(string sp, ComboBox combo, string display, string value)
        {
            DataTable tabla = helper.ConsultarSQL(sp);
            combo.DataSource = tabla;
            combo.DisplayMember = display;
            combo.ValueMember = value;           
        }

        public void ProximoID()
        {
            lblNro.Text = "RECETA N°: " + helper.ProximaReceta().ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la receta", "AVISO", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(txtCheff.Text))
            {
                MessageBox.Show("Ingrese un Cheff", "AVISO", MessageBoxButtons.OK);
            }
            foreach(DataGridViewRow row in dgvReceta.Rows)
            {
                if (row.Cells["colIngrediente"].Value.ToString().Equals(cboIngredientes.Text))
                {
                    MessageBox.Show("Ese Ingrediente ya está cargado", "AVISO", MessageBoxButtons.OK);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboIngredientes.SelectedItem;

            int idIngrediente = int.Parse(item.Row.ItemArray[0].ToString());
            string ingrediente = item.Row.ItemArray[1].ToString();
            string unidad = txtUnidad.Text;         
            Ingrediente oIngrediente = new Ingrediente(idIngrediente,ingrediente,unidad);

            int cantidad = int.Parse(txtCantidad.Text.ToString());

            Detalle = new DetalleReceta(oIngrediente, cantidad);
            
            receta.AgregarDetalle(Detalle);
            dgvReceta.Rows.Add(new object[] { idIngrediente, ingrediente, cantidad });
            ActualizarIngredientes();

        }

        private void ActualizarIngredientes()
        {
            int cant = 0;
            foreach(DataGridViewRow item in dgvReceta.Rows)
            {
                cant++;
            }
            
            txtIngre.Text = cant.ToString();
        }
        private int ContarIngres()
        {
            int cant = 0;
            foreach (DataGridViewRow item in dgvReceta.Rows)
            {
                cant++;
            }

            return cant;
        }
        private void Limpiar()
        {
            txtCantidad.Clear();
            txtNombre.Clear();
            txtCantidad.Text = "1";
            txtUnidad.Text = "Grs";
            cboIngredientes.SelectedIndex = 1;
            cboTipo.SelectedIndex = 1;
            dgvReceta.Rows.Clear();
            receta = new Receta();
            txtCheff.Clear();
            txtIngre.Clear();

        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvReceta.CurrentCell.ColumnIndex == 3)
            {
                receta.QuitarDetalle(dgvReceta.CurrentRow.Index);
                dgvReceta.Rows.Remove(dgvReceta.CurrentRow);
                ActualizarIngredientes();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ContarIngres() < 3)
            {
                MessageBox.Show("Ha olvidado Ingredientes? Minimo 3", "Revision", MessageBoxButtons.OK);
                return;
            }
            else
            {
                receta.Nombre = txtNombre.Text;
                receta.Cheff = txtCheff.Text;
                receta.TipoReceta = (int)cboTipo.SelectedValue;
                if (helper.CargarReceta(receta))
                {
                    MessageBox.Show("La Receta se cargó exitosamente", "Confirmacion", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("ERROR, no se cargo nada", "Confirmacion", MessageBoxButtons.OK);
                }
                Limpiar();
                ProximoID();
            }
            
        }
    }
}
