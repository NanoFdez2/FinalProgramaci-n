using ClassLibrary1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Triangulo triangulo;
        public Triangulo GetTriangulo()
        {
            return triangulo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColorRelleno();
            if (triangulo != null )
            {
                txtLado1.Text= triangulo.LadoA.ToString();
                txtLado2.Text= triangulo.LadoB.ToString();
                txtLado3.Text= triangulo.LadoC.ToString();
                cboColor.SelectedItem=triangulo.ColorRelleno;
                if(triangulo.TipoDeBorde==TipoDeBorde.Lineal)
                {
                    rbtLineal.Checked = true;
                }
                else if (triangulo.TipoDeBorde == TipoDeBorde.Rayas)
                {
                    rbtRayas.Checked = true;
                }
                else 
                {
                    rbtPuntos.Checked = true;
                }

            }
        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            cboColor.DataSource = listaColores;
            cboColor.SelectedIndex = 0;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (triangulo == null)
                {
                    triangulo = new Triangulo();
                }

                triangulo.SetLadoA(int.Parse(txtLado1.Text));
                triangulo.SetLadoB(int.Parse(txtLado2.Text));
                triangulo.SetLadoC(int.Parse(txtLado3.Text));
                triangulo.ColorRelleno = (ColorRelleno)cboColor.SelectedItem;

                if (rbtLineal.Checked)
                {
                    triangulo.TipoDeBorde = TipoDeBorde.Lineal;
                }
                else if (rbtRayas.Checked)
                {
                    triangulo.TipoDeBorde = TipoDeBorde.Rayas;
                }
                else
                {
                    triangulo.TipoDeBorde = TipoDeBorde.Puntos;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (!int.TryParse(txtLado1.Text, out int ladoA) || ladoA <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado1, "Número no válido");
            }
            if (!int.TryParse(txtLado2.Text, out int ladoB) || ladoB <= 0)
            {
                valido = false; ;
                errorProvider2.SetError(txtLado2, "Número no válido");
            }
            if (!int.TryParse(txtLado3.Text, out int ladoC) || ladoC <= 0)
            {
                valido = false;
                errorProvider3.SetError(txtLado3, "Número no válido");
            }
            if (valido && (ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA))
            {
                valido = false;
                errorProvider1.SetError(txtLado1, "Los lados no forman un triángulo");
                errorProvider2.SetError(txtLado2, "Los lados no forman un triángulo");
                errorProvider3.SetError(txtLado2, "Los lados no forman un triángulo");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLado1.Text = "0";
            txtLado2.Text = "0";
            txtLado3.Text = "0";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        internal void SetTriangulo(Triangulo triangulo)
        {
            this.triangulo = triangulo;
        }
    }
}
