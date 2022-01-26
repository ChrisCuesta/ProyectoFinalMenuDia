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
    public partial class RegistroSopa : Form
    {
        WcfMenuDiaClient ws = new WcfMenuDiaClient();
        SopasEntidad sopa = new SopasEntidad();
        public RegistroSopa()
        {
            InitializeComponent();
        }

       

        private void guardarSopa()
        {
            sopa.NomSopa = textBox_NomSopa.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img_sopa.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            sopa.ImgSopa = ms.GetBuffer();
            string ing = null;
            if (checkBox1.Checked)
            {
                ing = ing + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                ing = ing + " ,"+checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                ing = ing + " ,"+checkBox3.Text;
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
            sopa.IngSopa = ing;
            sopa = ws.GuardarSopa(sopa);
        }

        private void btnImagenSopa_Click(object sender, EventArgs e)
        {
            OpenFileDialog sopa = new OpenFileDialog();
            DialogResult rs = sopa.ShowDialog();
            if (rs == DialogResult.OK)
            {
                img_sopa.Image = Image.FromFile(sopa.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            guardarSopa();
            cargartabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdSopa"].Value.ToString());
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImgSopa"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            img_sopa.Image = Image.FromStream(ms);
            cargarPorId(id);
        }

        private void cargarPorId(int id)
        {
            sopa = ws.DevolverSopasPorId(id);
            textBoxId.Text = Convert.ToString(sopa.IdSopa);
            textBox_NomSopa.Text = sopa.NomSopa;
        }

        private void RegistroSopa_Load(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void cargartabla()
        {
            dataGridView1.DataSource = ws.DevolverListaSopas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar();
            cargartabla();
        }

        private void eliminar()
        {
            if (MessageBox.Show("Esta seguro de eliminar el item?", "Eliminar Sopa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ws.EliminarSopa(sopa.IdSopa))
                {
                    MessageBox.Show("Item Eliminado Satisfactoriamente", "Archivo Eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
