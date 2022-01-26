using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Presentacion.wsMenuDia;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarMenu();
        }

        private void cargarMenu()
        {
            dataGridView1.DataSource = ws.DevolverListaMenuDiaJoin();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarMenu();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            VentanaCreacion();
            cargarMenu();
        }

        private void VentanaCreacion()
        {
            VentanaCreacion ve = new VentanaCreacion();
            ve.Show();
        }
    }
}
