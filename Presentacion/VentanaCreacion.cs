using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Presentacion.wsMenuDia;

namespace Presentacion
{
    public partial class VentanaCreacion : Form
    {
        MenuDiaEntidad menu = new MenuDiaEntidad();
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        public VentanaCreacion()
        {
            InitializeComponent();
        }

        private void btnSopa_Click(object sender, EventArgs e)
        {
            RegistroSopa sopa = new RegistroSopa();
            sopa.Show();
            cargarCombobox();
        }


        private void btnSegundo_Click(object sender, EventArgs e)
        {
            RegistroSegundo segundo = new RegistroSegundo();
            segundo.Show();
            cargarCombobox();
        }

        private void btnBebida_Click(object sender, EventArgs e)
        {
            RegistroBebidas bebida = new RegistroBebidas();
            bebida.Show();
            cargarCombobox();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            RegistroEntradas entrada = new RegistroEntradas();
            entrada.Show();
            cargarCombobox();
        }


        private void VentanaCreacion_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            cargarTabla();
        }

        public void cargarTabla()
        {
            dataGridView1.DataSource = ws.DevolverListaMenuDiaJoin();
        }

        private void cargarCombobox()
        {
            comboBox_sopa.DataSource = SopaNegocio.DevolverListaSopas();
            comboBox_sopa.DisplayMember = "NomSopa";
            comboBox_sopa.ValueMember = "IdSopa";
            comboBox_segundo.DataSource = SegundoNegocio.DevolverListaSegundos();
            comboBox_segundo.DisplayMember = "NomSegundo";
            comboBox_segundo.ValueMember = "IdSegundo";
            comboBox_bebida.DataSource = BebidasNegocio.DevolverListaBebidas();
            comboBox_bebida.DisplayMember = "NomBebida";
            comboBox_bebida.ValueMember = "IdBebida";
            comboBox_entrada.DataSource = EntradasNegocio.DevolverListaEntrada();
            comboBox_entrada.DisplayMember = "NomEntrada";
            comboBox_entrada.ValueMember = "IdEntrada";
            restablecerCombo();
            
        }

        private void restablecerCombo()
        {
            comboBox_sopa.SelectedIndex = -1;
            comboBox_entrada.SelectedIndex = -1;
            comboBox_bebida.SelectedIndex = -1;
            comboBox_segundo.SelectedIndex = -1;
            textBoxId.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int id = (int)comboBox_sopa.SelectedValue;
            int idseg = (int)comboBox_segundo.SelectedValue;
            int idbeb = (int)comboBox_bebida.SelectedValue;
            int ident = (int)comboBox_entrada.SelectedValue;
            menu.IdSopaPer = id;
            menu.IdSegPer = idseg;
            menu.IdBebPer = idbeb;
            menu.IdEntPer = ident;
            menu.FecMen = dateTimePicker1.Value;
            menu = ws.GuardarMenuDia(menu);
            cargarTabla();
            restablecerCombo();
            cargarCombobox();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            cargarTabla();
            restablecerCombo();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el item?", "Eliminar Menú",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ws.EliminarMenuDia(menu.NumMen))
                {
                    MessageBox.Show("Item Eliminado Satisfactoriamente", "Archivo Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
            comboBox_sopa.Text = dataGridView1.Rows[e.RowIndex].Cells["Sopa"].Value.ToString();
            comboBox_segundo.Text = dataGridView1.Rows[e.RowIndex].Cells["Segundo"].Value.ToString();
            comboBox_bebida.Text = dataGridView1.Rows[e.RowIndex].Cells["Bebida"].Value.ToString();
            comboBox_entrada.Text = dataGridView1.Rows[e.RowIndex].Cells["Entrada"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            
            cargarPorId(id);
            int idsopa = (int)comboBox_sopa.SelectedValue;
            int idseg = (int)comboBox_segundo.SelectedValue;
            int idbeb = (int)comboBox_bebida.SelectedValue;
            int ident = (int)comboBox_entrada.SelectedValue;
            CargarIngredientes(idsopa, idseg, idbeb, ident);
        }

        private void CargarIngredientes(int idsopa, int idsegundo, int idbebida, int identrada)
        {
            textBoxSopa.Text = ws.DevolverIngredientesSopasPorId(idsopa).IngSopa;
            textBoxSegundo.Text = ws.DevolverIngredientesSegundoPorId(idsegundo).IngSegundo;
            textBoxBebida.Text = ws.DevolverIngredientesBebidaPorId(idbebida).IngBebida;
            textBoxEntrada.Text = ws.DevolverIngredientesEntradaPorId(identrada).IngEntrada;
        }

        private void cargarPorId(int id)
        {
            menu = ws.DevolverMenuDiaPorId(id);
            textBoxId.Text = menu.NumMen.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
