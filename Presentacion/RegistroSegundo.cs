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
    public partial class RegistroSegundo : Form
    {
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        SegundosEntidad segundo = new SegundosEntidad();
        public RegistroSegundo()
        {
            InitializeComponent();
        }

        private void RegistroSegundo_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            dataGridView1.DataSource =ws.DevolverListaSegundos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarSegundo();
            cargarTabla();
        }

        private void guardarSegundo()
        {
            segundo.NomSegundo = textBox_NomSeg.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox_Segundo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            segundo.ImgSegundo = ms.GetBuffer();
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
            segundo.IngSegundo = ing;
            segundo = ws.GuardarSegundo(segundo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar();
            cargarTabla();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el item?", "Eliminar Segundo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ws.EliminarSegundo(segundo.IdSegundo))
                {
                    MessageBox.Show("Item Eliminado Satisfactoriamente", "Archivo Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdSegundo"].Value.ToString());
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImgSegundo"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            pictureBox_Segundo.Image = Image.FromStream(ms);
            cargarPorId(id);
        }

        private void cargarPorId(int id)
        {
            segundo = ws.DevolverSegundosPorId(id);
            textBoxId.Text = Convert.ToString(segundo.IdSegundo);
            textBox_NomSeg.Text = segundo.NomSegundo;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog segundo = new OpenFileDialog();
            DialogResult rs = segundo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBox_Segundo.Image = Image.FromFile(segundo.FileName);
            }
        }
    }
}
