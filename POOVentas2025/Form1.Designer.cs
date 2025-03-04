namespace POOVentas2025
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
            label1 = new Label();
            TxtCliente = new TextBox();
            label2 = new Label();
            TxtPanFrances = new TextBox();
            label3 = new Label();
            TxtBolillo = new TextBox();
            label4 = new Label();
            TxtCupcake = new TextBox();
            Agregar = new Button();
            DgvPan = new DataGridView();
            label5 = new Label();
            TxtTotal = new TextBox();
            TxtPrecioPanFrances = new TextBox();
            TxtPrecioBolillo = new TextBox();
            TxtInteresCupcake = new TextBox();
            btnRestaurar = new Button();
            rbtnContado = new RadioButton();
            rbtnCredito = new RadioButton();
            Cliente = new DataGridViewTextBoxColumn();
            Frances = new DataGridViewTextBoxColumn();
            Bolillo = new DataGridViewTextBoxColumn();
            Cupcake = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvPan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // TxtCliente
            // 
            TxtCliente.ForeColor = Color.Fuchsia;
            TxtCliente.Location = new Point(182, 19);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(125, 27);
            TxtCliente.TabIndex = 1;
            TxtCliente.TextChanged += TxtCliente_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Pan Frances";
            label2.Click += label2_Click;
            // 
            // TxtPanFrances
            // 
            TxtPanFrances.ForeColor = Color.DeepPink;
            TxtPanFrances.Location = new Point(182, 72);
            TxtPanFrances.Name = "TxtPanFrances";
            TxtPanFrances.Size = new Size(125, 27);
            TxtPanFrances.TabIndex = 3;
            TxtPanFrances.Text = "0";
            TxtPanFrances.TextAlign = HorizontalAlignment.Center;
            TxtPanFrances.TextChanged += TxtPanFrances_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 135);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Bolillo";
            label3.Click += label3_Click;
            // 
            // TxtBolillo
            // 
            TxtBolillo.ForeColor = Color.DeepPink;
            TxtBolillo.Location = new Point(182, 135);
            TxtBolillo.Name = "TxtBolillo";
            TxtBolillo.Size = new Size(125, 27);
            TxtBolillo.TabIndex = 5;
            TxtBolillo.Text = "0";
            TxtBolillo.TextAlign = HorizontalAlignment.Center;
            TxtBolillo.TextChanged += TxtBolillo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 191);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Cupcake";
            label4.Click += label4_Click;
            // 
            // TxtCupcake
            // 
            TxtCupcake.ForeColor = Color.DeepPink;
            TxtCupcake.Location = new Point(182, 191);
            TxtCupcake.Name = "TxtCupcake";
            TxtCupcake.Size = new Size(125, 27);
            TxtCupcake.TabIndex = 7;
            TxtCupcake.Text = "0";
            TxtCupcake.TextAlign = HorizontalAlignment.Center;
            TxtCupcake.TextChanged += TxtCupcake_TextChanged;
            // 
            // Agregar
            // 
            Agregar.ForeColor = Color.Aqua;
            Agregar.Location = new Point(233, 328);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(141, 43);
            Agregar.TabIndex = 8;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // DgvPan
            // 
            DgvPan.BackgroundColor = Color.BlueViolet;
            DgvPan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPan.Columns.AddRange(new DataGridViewColumn[] { Cliente, Frances, Bolillo, Cupcake, Total, TipoPago });
            DgvPan.GridColor = Color.FromArgb(255, 128, 255);
            DgvPan.Location = new Point(520, 19);
            DgvPan.Name = "DgvPan";
            DgvPan.RowHeadersWidth = 51;
            DgvPan.Size = new Size(803, 479);
            DgvPan.TabIndex = 9;
            DgvPan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 273);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 10;
            label5.Text = "Total";
            label5.Click += label5_Click;
            // 
            // TxtTotal
            // 
            TxtTotal.ForeColor = Color.OrangeRed;
            TxtTotal.Location = new Point(233, 273);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(125, 27);
            TxtTotal.TabIndex = 11;
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            TxtTotal.TextChanged += TxtTotal_TextChanged;
            // 
            // TxtPrecioPanFrances
            // 
            TxtPrecioPanFrances.Location = new Point(345, 75);
            TxtPrecioPanFrances.Name = "TxtPrecioPanFrances";
            TxtPrecioPanFrances.Size = new Size(125, 27);
            TxtPrecioPanFrances.TabIndex = 12;
            TxtPrecioPanFrances.Text = "0.00";
            TxtPrecioPanFrances.TextAlign = HorizontalAlignment.Center;
            TxtPrecioPanFrances.TextChanged += textBox1_TextChanged;
            // 
            // TxtPrecioBolillo
            // 
            TxtPrecioBolillo.Location = new Point(345, 135);
            TxtPrecioBolillo.Name = "TxtPrecioBolillo";
            TxtPrecioBolillo.Size = new Size(125, 27);
            TxtPrecioBolillo.TabIndex = 13;
            TxtPrecioBolillo.Text = "0.00";
            TxtPrecioBolillo.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtInteresCupcake
            // 
            TxtInteresCupcake.Location = new Point(345, 191);
            TxtInteresCupcake.Name = "TxtInteresCupcake";
            TxtInteresCupcake.Size = new Size(125, 27);
            TxtInteresCupcake.TabIndex = 14;
            TxtInteresCupcake.Text = "0.00";
            TxtInteresCupcake.TextAlign = HorizontalAlignment.Center;
            TxtInteresCupcake.TextChanged += TxtInteresCupcake_TextChanged;
            // 
            // btnRestaurar
            // 
            btnRestaurar.ForeColor = Color.DarkCyan;
            btnRestaurar.Location = new Point(233, 389);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(141, 43);
            btnRestaurar.TabIndex = 15;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // rbtnContado
            // 
            rbtnContado.AutoSize = true;
            rbtnContado.Location = new Point(64, 347);
            rbtnContado.Name = "rbtnContado";
            rbtnContado.Size = new Size(87, 24);
            rbtnContado.TabIndex = 16;
            rbtnContado.TabStop = true;
            rbtnContado.Text = "Contado";
            rbtnContado.UseVisualStyleBackColor = true;
            rbtnContado.CheckedChanged += rbtnContado_CheckedChanged;
            // 
            // rbtnCredito
            // 
            rbtnCredito.AutoSize = true;
            rbtnCredito.Location = new Point(64, 408);
            rbtnCredito.Name = "rbtnCredito";
            rbtnCredito.Size = new Size(79, 24);
            rbtnCredito.TabIndex = 17;
            rbtnCredito.TabStop = true;
            rbtnCredito.Text = "Credito";
            rbtnCredito.UseVisualStyleBackColor = true;
            rbtnCredito.CheckedChanged += rbtnCredito_CheckedChanged;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Frances
            // 
            Frances.HeaderText = "Frances";
            Frances.MinimumWidth = 6;
            Frances.Name = "Frances";
            Frances.Width = 125;
            // 
            // Bolillo
            // 
            Bolillo.HeaderText = "Bolillo";
            Bolillo.MinimumWidth = 6;
            Bolillo.Name = "Bolillo";
            Bolillo.Width = 125;
            // 
            // Cupcake
            // 
            Cupcake.HeaderText = "Cupcake";
            Cupcake.MinimumWidth = 6;
            Cupcake.Name = "Cupcake";
            Cupcake.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // TipoPago
            // 
            TipoPago.HeaderText = "Tipo de Pago";
            TipoPago.MinimumWidth = 6;
            TipoPago.Name = "TipoPago";
            TipoPago.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 595);
            Controls.Add(rbtnCredito);
            Controls.Add(rbtnContado);
            Controls.Add(btnRestaurar);
            Controls.Add(TxtInteresCupcake);
            Controls.Add(TxtPrecioBolillo);
            Controls.Add(TxtPrecioPanFrances);
            Controls.Add(TxtTotal);
            Controls.Add(label5);
            Controls.Add(DgvPan);
            Controls.Add(Agregar);
            Controls.Add(TxtCupcake);
            Controls.Add(label4);
            Controls.Add(TxtBolillo);
            Controls.Add(label3);
            Controls.Add(TxtPanFrances);
            Controls.Add(label2);
            Controls.Add(TxtCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtCliente;
        private Label label2;
        private TextBox TxtPanFrances;
        private Label label3;
        private TextBox TxtBolillo;
        private Label label4;
        private TextBox TxtCupcake;
        private Button Agregar;
        private DataGridView DgvPan;
        private Label label5;

        public string TxtMonto { get; private set; }

        private TextBox TxtTotal;
        private TextBox TxtPrecioPanFrances;
        private TextBox TxtPrecioBolillo;
        private TextBox TxtInteresCupcake;
        private Button btnRestaurar;
        private RadioButton rbtnContado;
        private RadioButton rbtnCredito;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Frances;
        private DataGridViewTextBoxColumn Bolillo;
        private DataGridViewTextBoxColumn Cupcake;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn TipoPago;
    }
}
