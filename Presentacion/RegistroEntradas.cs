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
    public partial class RegistroEntradas : Form
    {
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        EntradasEntidad entrada = new EntradasEntidad();
        public RegistroEntradas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdEntrada"].Value.ToString());
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImgEntrada"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            img_entrada.Image = Image.FromStream(ms);
            cargarPorId(id);
        }

        private void cargarPorId(int id)
        {
            entrada = ws.DevolverEntradasPorId(id);
            textBoxId.Text = Convert.ToString(entrada.IdEntrada);
            textBox_NomSopa.Text = entrada.NomEntrada;
        }

        private void RegistroEntradas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            dataGridView1.DataSource = ws.DevolverListaEntrada();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            entrada.NomEntrada = textBox_NomSopa.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img_entrada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            entrada.ImgEntrada = ms.GetBuffer();
            string ing = null;
            if (checkBox1.Checked)
            {
                ing = ing + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                ing = ing + " ," + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                ing = ing + " ," + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                ing = ing + " ," + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                ing = ing + " ," + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                ing = ing + " ," + checkBox6.Text;
            }
            entrada.IngEntrada = ing;
            entrada = ws.GuardarEntrada(entrada);
            cargarTabla();
            
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog entrada = new OpenFileDialog();
            DialogResult rs = entrada.ShowDialog();
            if (rs == DialogResult.OK)
            {
                img_entrada.Image = Image.FromFile(entrada.FileName);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            cargarTabla();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el item?", "Eliminar Entrada",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ws.EliminarEntrada(entrada.IdEntrada))
                {
                    MessageBox.Show("Item Eliminado Satisfactoriamente", "Archivo Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
