namespace _2Practica
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            txtLado3 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            btnAgregar = new Button();
            btnCancelar = new Button();
            cboColor = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            rbtLineal = new RadioButton();
            rbtRayas = new RadioButton();
            rbtPuntos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Medida lado 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Medida lado 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Medida lado 2";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(100, 6);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(136, 23);
            txtLado1.TabIndex = 3;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(100, 45);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(136, 23);
            txtLado2.TabIndex = 4;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(100, 87);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(136, 23);
            txtLado3.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(19, 212);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 45);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(241, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(489, 9);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(121, 23);
            cboColor.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 12);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 87);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "Borde";
            // 
            // rbtLineal
            // 
            rbtLineal.AutoSize = true;
            rbtLineal.Location = new Point(489, 85);
            rbtLineal.Name = "rbtLineal";
            rbtLineal.Size = new Size(56, 19);
            rbtLineal.TabIndex = 12;
            rbtLineal.TabStop = true;
            rbtLineal.Text = "Lineal";
            rbtLineal.UseVisualStyleBackColor = true;
            // 
            // rbtRayas
            // 
            rbtRayas.AutoSize = true;
            rbtRayas.Location = new Point(489, 124);
            rbtRayas.Name = "rbtRayas";
            rbtRayas.Size = new Size(55, 19);
            rbtRayas.TabIndex = 13;
            rbtRayas.TabStop = true;
            rbtRayas.Text = "Rayas";
            rbtRayas.UseVisualStyleBackColor = true;
            // 
            // rbtPuntos
            // 
            rbtPuntos.AutoSize = true;
            rbtPuntos.Location = new Point(489, 162);
            rbtPuntos.Name = "rbtPuntos";
            rbtPuntos.Size = new Size(62, 19);
            rbtPuntos.TabIndex = 14;
            rbtPuntos.TabStop = true;
            rbtPuntos.Text = "Puntos";
            rbtPuntos.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtPuntos);
            Controls.Add(rbtRayas);
            Controls.Add(rbtLineal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboColor);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtLado3);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLado1;
        private TextBox txtLado2;
        private TextBox txtLado3;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnAgregar;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Label label5;
        private Label label4;
        private ComboBox cboColor;
        private RadioButton rbtLineal;
        private RadioButton rbtPuntos;
        private RadioButton rbtRayas;
    }
}