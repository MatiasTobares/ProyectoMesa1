using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoooo
{
    public partial class Form1 : Form
    {
        int n = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Operacion para sacar el total de los productos.
            double a = Convert.ToDouble(txtUnidades.Text);
            double b = Convert.ToDouble(txtCostoUnidad.Text);
            double r = a * b;

          
            //Operacion para porcentaje.
            double c = Convert.ToDouble(txtPorcentaje.Text);
            
            double rp = r - c * r /100;

           
            //Ingreso de nueva fila
            int n = dtvProductos.Rows.Add();

            //Se carga la informacion
            dtvProductos.Rows[n].Cells[0].Value = txtMarca.Text;
            dtvProductos.Rows[n].Cells[1].Value = txtNSerie.Text;
            dtvProductos.Rows[n].Cells[2].Value = txtUnidades.Text;
            dtvProductos.Rows[n].Cells[3].Value = txtCostoUnidad.Text;
            if(rbtDeportivo.Checked)
            {
                string mensajeDep = "Deportivo";
                dtvProductos.Rows[n].Cells[4].Value = mensajeDep;
            }
            else
            {
                string mensajeFor = "Formal";
                dtvProductos.Rows[n].Cells[4].Value = mensajeFor;
            }
            if (rbtCasual.Checked)
            {
                string mensajeCasual = "Casual";
                dtvProductos.Rows[n].Cells[4].Value = mensajeCasual;
            }
            if(rbtOtro.Checked)
            {
                string mensajeotro = "Otro";
                dtvProductos.Rows[n].Cells[4].Value = mensajeotro;
            }

            dtvProductos.Rows[n].Cells[5].Value = r.ToString();
            dtvProductos.Rows[n].Cells[6].Value = rp.ToString();

            //Se limpian las celdas luego de cargar datos
            borrarCeldas();


        }

        //Nos permite borrar la fila de un elemento seleccionador
        private void button2_Click(object sender, EventArgs e)
        {
            if(n!= -1)
            {
                dtvProductos.Rows.RemoveAt(n);
            }
        }

        //----------------------SUBPROGRAMAS Y OTRAS FUNCIONES----------------

        //Permite borrar las celdas, una vez que se carguen los datos
        private void borrarCeldas()
        {
            txtMarca.Text = "";
            txtNSerie.Text = "";
            txtUnidades.Text = "";
            txtCostoUnidad.Text = "";
            txtPorcentaje.Text = "";
        }

        // VALIDACION SOLO NUMEROS
        //txt Numero de Serie
        private void txtNSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtNSerie, "Solo valores númericos");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtNSerie, "");
            }
        }

        //txt Unidades
        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtUnidades, "Solo valores númericos");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtUnidades, "");
            }
        }

        //txt Costo Unidad
        private void txtCostoUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtCostoUnidad, "Solo valores númericos");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtCostoUnidad, "");
            }

        }

        //txt Porcentanje (valida el porcentaje)
        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtPorcentaje, "Solo valores númericos");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtPorcentaje, "");
                
            }

        }

        //VALIDACION SOLO LETRAS
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtMarca, "Solo se permite letras");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(txtMarca, "");
            }
        }

       
    }
}
