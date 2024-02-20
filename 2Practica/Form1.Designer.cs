namespace _2Practica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            tsbOrdenar = new ToolStripButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            lado1ToolStripMenuItem = new ToolStripMenuItem();
            ascendenteToolStripMenuItem = new ToolStripMenuItem();
            descendenteToolStripMenuItem = new ToolStripMenuItem();
            lado2ToolStripMenuItem = new ToolStripMenuItem();
            ascendenteToolStripMenuItem1 = new ToolStripMenuItem();
            descendenteToolStripMenuItem1 = new ToolStripMenuItem();
            lado3ToolStripMenuItem = new ToolStripMenuItem();
            ascendenteToolStripMenuItem2 = new ToolStripMenuItem();
            descendenteToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbEliminar = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            label1 = new Label();
            txtCantidad = new TextBox();
            dataGridView1 = new DataGridView();
            colLado1 = new DataGridViewTextBoxColumn();
            colLado2 = new DataGridViewTextBoxColumn();
            colLado3 = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbFiltrar, tsbActualizar, tsbOrdenar, toolStripSplitButton1, toolStripSeparator1, tsbEliminar, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(875, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 35);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 35);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.Image = (Image)resources.GetObject("tsbOrdenar.Image");
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(54, 35);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbOrdenar.Click += tsbOrdenar_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { lado1ToolStripMenuItem, lado2ToolStripMenuItem, lado3ToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 35);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // lado1ToolStripMenuItem
            // 
            lado1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem, descendenteToolStripMenuItem });
            lado1ToolStripMenuItem.Name = "lado1ToolStripMenuItem";
            lado1ToolStripMenuItem.Size = new Size(109, 22);
            lado1ToolStripMenuItem.Text = "Lado 1";
            // 
            // ascendenteToolStripMenuItem
            // 
            ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            ascendenteToolStripMenuItem.Size = new Size(142, 22);
            ascendenteToolStripMenuItem.Text = "Ascendente";
            ascendenteToolStripMenuItem.Click += ascendenteToolStripMenuItem_Click;
            // 
            // descendenteToolStripMenuItem
            // 
            descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            descendenteToolStripMenuItem.Size = new Size(142, 22);
            descendenteToolStripMenuItem.Text = "Descendente";
            descendenteToolStripMenuItem.Click += descendenteToolStripMenuItem_Click;
            // 
            // lado2ToolStripMenuItem
            // 
            lado2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem1, descendenteToolStripMenuItem1 });
            lado2ToolStripMenuItem.Name = "lado2ToolStripMenuItem";
            lado2ToolStripMenuItem.Size = new Size(109, 22);
            lado2ToolStripMenuItem.Text = "Lado 2";
            // 
            // ascendenteToolStripMenuItem1
            // 
            ascendenteToolStripMenuItem1.Name = "ascendenteToolStripMenuItem1";
            ascendenteToolStripMenuItem1.Size = new Size(142, 22);
            ascendenteToolStripMenuItem1.Text = "Ascendente";
            ascendenteToolStripMenuItem1.Click += ascendenteToolStripMenuItem1_Click;
            // 
            // descendenteToolStripMenuItem1
            // 
            descendenteToolStripMenuItem1.Name = "descendenteToolStripMenuItem1";
            descendenteToolStripMenuItem1.Size = new Size(142, 22);
            descendenteToolStripMenuItem1.Text = "Descendente";
            descendenteToolStripMenuItem1.Click += descendenteToolStripMenuItem1_Click;
            // 
            // lado3ToolStripMenuItem
            // 
            lado3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem2, descendenteToolStripMenuItem2 });
            lado3ToolStripMenuItem.Name = "lado3ToolStripMenuItem";
            lado3ToolStripMenuItem.Size = new Size(109, 22);
            lado3ToolStripMenuItem.Text = "Lado 3";
            // 
            // ascendenteToolStripMenuItem2
            // 
            ascendenteToolStripMenuItem2.Name = "ascendenteToolStripMenuItem2";
            ascendenteToolStripMenuItem2.Size = new Size(142, 22);
            ascendenteToolStripMenuItem2.Text = "Ascendente";
            ascendenteToolStripMenuItem2.Click += ascendenteToolStripMenuItem2_Click;
            // 
            // descendenteToolStripMenuItem2
            // 
            descendenteToolStripMenuItem2.Name = "descendenteToolStripMenuItem2";
            descendenteToolStripMenuItem2.Size = new Size(142, 22);
            descendenteToolStripMenuItem2.Text = "Descendente";
            descendenteToolStripMenuItem2.Click += descendenteToolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(54, 35);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCantidad);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(94, 6);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(169, 23);
            txtCantidad.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colLado1, colLado2, colLado3, colTipo, colColor, colBorde, colArea, colPerimetro });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(875, 312);
            dataGridView1.TabIndex = 2;
            // 
            // colLado1
            // 
            colLado1.HeaderText = "Lado 1";
            colLado1.Name = "colLado1";
            // 
            // colLado2
            // 
            colLado2.HeaderText = "Lado 2";
            colLado2.Name = "colLado2";
            // 
            // colLado3
            // 
            colLado3.HeaderText = "Lado 3";
            colLado3.Name = "colLado3";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Triangulo";
            colTipo.Name = "colTipo";
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            // 
            // colBorde
            // 
            colBorde.HeaderText = "Borde";
            colBorde.Name = "colBorde";
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            // 
            // colPerimetro
            // 
            colPerimetro.HeaderText = "Perimetro";
            colPerimetro.Name = "colPerimetro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbOrdenar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colLado1;
        private DataGridViewTextBoxColumn colLado2;
        private DataGridViewTextBoxColumn colLado3;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colPerimetro;
        private Label label1;
        private TextBox txtCantidad;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem lado1ToolStripMenuItem;
        private ToolStripMenuItem ascendenteToolStripMenuItem;
        private ToolStripMenuItem descendenteToolStripMenuItem;
        private ToolStripMenuItem lado2ToolStripMenuItem;
        private ToolStripMenuItem ascendenteToolStripMenuItem1;
        private ToolStripMenuItem descendenteToolStripMenuItem1;
        private ToolStripMenuItem lado3ToolStripMenuItem;
        private ToolStripMenuItem ascendenteToolStripMenuItem2;
        private ToolStripMenuItem descendenteToolStripMenuItem2;
    }
}
