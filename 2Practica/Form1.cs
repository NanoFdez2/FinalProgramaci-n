using ClassLibrary1.Datos;
using ClassLibrary1.Entidades;

namespace _2Practica
{
    public partial class Form1 : Form
    {
        private RepositorioDeTriangulos repo;
        private List<Triangulo> lista;
        int valorFiltro;
        bool filterOn = false;
        public Form1()
        {
            InitializeComponent();
            repo = new RepositorioDeTriangulos();
            ActualizarCantidadDeRegistros();
            txtCantidad.Text = repo.GetCantidad().ToString();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Form2 Form = new Form2() { Text = "Agregue un triángulo" };
            DialogResult dr = Form.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Triangulo triangulo = Form.GetTriangulo();
            if (!repo.Existe(triangulo))
            {
                repo.Agregar(triangulo);
                ActualizarCantidadDeRegistros();
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, triangulo);
                AgregarFila(l);
                MessageBox.Show("Fila agregada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AgregarFila(DataGridViewRow l)
        {
            dataGridView1.Rows.Add(l);
        }

        private void SetearFila(DataGridViewRow l, Triangulo triangulo)
        {
            l.Cells[colLado1.Index].Value = triangulo.GetLadoA();
            l.Cells[colLado2.Index].Value = triangulo.GetLadoB();
            l.Cells[colLado3.Index].Value = triangulo.GetLadoC();
            l.Cells[colColor.Index].Value = triangulo.ColorRelleno;
            l.Cells[colBorde.Index].Value = triangulo.TipoDeBorde;
            l.Cells[colArea.Index].Value = triangulo.GetSuperficie().ToString(".0");
            l.Cells[colPerimetro.Index].Value = triangulo.GetPerimetro().ToString(".0");
            l.Tag = triangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var l = new DataGridViewRow();
            l.CreateCells(dataGridView1);
            return l;
        }

        private void ActualizarCantidadDeRegistros()
        {
            if (valorFiltro > 0)
            {
                txtCantidad.Text = repo.GetCantidad(valorFiltro).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            else
            {
                var l = dataGridView1.SelectedRows[0];
                QuitarFila(l);
                var borrar = (Triangulo)l.Tag;
                repo.Borrar(borrar);
                ActualizarCantidadDeRegistros();
                MessageBox.Show("Fila eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuitarFila(DataGridViewRow l)
        {
            dataGridView1.Rows.Remove(l);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var FilaSeleccionada = dataGridView1.SelectedRows[0];
            Triangulo triangulo = (Triangulo)FilaSeleccionada.Tag;
            Triangulo trianguloCopia = (Triangulo)triangulo.clone();
            Form2 frm = new Form2() { Text = "Editar triangulo" };
            frm.SetTriangulo(triangulo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            triangulo = frm.GetTriangulo();
            if (!repo.Existe(triangulo))
            {
                repo.Editar(trianguloCopia, triangulo);
                SetearFila(FilaSeleccionada, triangulo);
                MessageBox.Show("Fila editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetearFila(FilaSeleccionada, trianguloCopia);
                MessageBox.Show("Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            if (!filterOn)
            {
                var lado1Filtro = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para filtrar",
            "Filtrar por Mayor",
            "0", 200, 200);
                if (!int.TryParse(lado1Filtro, out valorFiltro))
                {
                    return;
                }
                if (valorFiltro <= 0)
                {
                    return;
                }
                lista = repo.Filtrar(valorFiltro);
                tsbFiltrar.BackColor = Color.DarkRed;
                filterOn = true;
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros();

            }
            else
            {
                MessageBox.Show("Filtro aplicado! \n Debe actualizar la grilla",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dataGridView1.Rows.Clear();
            foreach (var rect in lista)
            {
                DataGridViewRow l = ConstruirFila();
                SetearFila(l, rect);
                AgregarFila(l);
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            valorFiltro = 0;
            filterOn = false;
            tsbFiltrar.BackColor = SystemColors.Control;
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL1();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void ascendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL2();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL2();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void ascendenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAscL3();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDescL3();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}

