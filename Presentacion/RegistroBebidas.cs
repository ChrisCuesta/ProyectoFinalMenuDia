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
    public partial class RegistroBebidas : Form
    {
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        BebidasEntidad bebida = new BebidasEntidad();
        public RegistroBebidas()
        {
            InitializeComponent();
        }

        private void RegistroBebidas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            dataGridView1.DataSource = ws.DevolverListaBebidas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdBebida"].Value.ToString());
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImgBebida"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            img_bebida.Image = Image.FromStream(ms);
            cargarPorId(id);
        }

        private void cargarPorId(int id)
        {
            bebida = ws.DevolverBebidasPorId(id);
            textBoxId.Text = Convert.ToString(bebida.IdBebida);
            textBox_NomBebida.Text = bebida.NomBebida;
        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog entrada = new OpenFileDialog();
            DialogResult rs = entrada.ShowDialog();
            if (rs == DialogResult.OK)
            {
                img_bebida.Image = Image.FromFile(entrada.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar();
            cargarTabla();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el item?", "Eliminar Bebida",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ws.EliminarBebida(bebida.IdBebida))
                {
                    MessageBox.Show("Item Eliminado Satisfactoriamente", "Archivo Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarBebida();
            cargarTabla();
        }

        private void guardarBebida()
        {
            bebida.NomBebida= textBox_NomBebida.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img_bebida.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bebida.ImgBebida = ms.GetBuffer();
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
            bebida.IngBebida = ing;
            bebida =  ws.GuardarBebida(bebida);
        }
    }
}
