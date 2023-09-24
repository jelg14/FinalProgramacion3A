namespace ExamenFinal
{
    partial class AgregarTelefono
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
            label1 = new Label();
            label2 = new Label();
            dtmFechaVenta = new DateTimePicker();
            label3 = new Label();
            cmbPais = new ComboBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbColor = new ComboBox();
            button1 = new Button();
            rdbX = new RadioButton();
            rdbMax = new RadioButton();
            txtMarca = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Gamma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha de Venta";
            // 
            // dtmFechaVenta
            // 
            dtmFechaVenta.Location = new Point(130, 65);
            dtmFechaVenta.Name = "dtmFechaVenta";
            dtmFechaVenta.Size = new Size(165, 23);
            dtmFechaVenta.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 98);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 10;
            label3.Text = "Pais de ensamblaje";
            label3.Click += label3_Click;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "Guatemala", "Brujas", "Amsterdam", "Londres" });
            cmbPais.Location = new Point(130, 94);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(165, 23);
            cmbPais.TabIndex = 9;
            cmbPais.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(130, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(113, 23);
            txtPrecio.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 131);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 155);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Color";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "blanco", "azul", "gris", "verde" });
            cmbColor.Location = new Point(130, 152);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(165, 23);
            cmbColor.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(17, 191);
            button1.Name = "button1";
            button1.Size = new Size(107, 52);
            button1.TabIndex = 15;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rdbX
            // 
            rdbX.AutoSize = true;
            rdbX.Location = new Point(130, 13);
            rdbX.Name = "rdbX";
            rdbX.Size = new Size(43, 19);
            rdbX.TabIndex = 16;
            rdbX.TabStop = true;
            rdbX.Text = "XSs";
            rdbX.UseVisualStyleBackColor = true;
            // 
            // rdbMax
            // 
            rdbMax.AutoSize = true;
            rdbMax.Location = new Point(179, 12);
            rdbMax.Name = "rdbMax";
            rdbMax.Size = new Size(74, 19);
            rdbMax.TabIndex = 17;
            rdbMax.TabStop = true;
            rdbMax.Text = "XSs Maxs";
            rdbMax.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(130, 36);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(165, 23);
            txtMarca.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 44);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 19;
            label6.Text = "Marca";
            // 
            // AgregarTelefono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 243);
            Controls.Add(label6);
            Controls.Add(txtMarca);
            Controls.Add(rdbMax);
            Controls.Add(rdbX);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(cmbColor);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(cmbPais);
            Controls.Add(dtmFechaVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarTelefono";
            Text = "AgregarTelefono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DateTimePicker dtmFechaVenta;
        private Label label3;
        private ComboBox cmbPais;
        private TextBox txtPrecio;
        private Label label4;
        private Label label5;
        private ComboBox cmbColor;
        private Button button1;
        private RadioButton rdbX;
        private RadioButton rdbMax;
        private TextBox txtMarca;
        private Label label6;
    }
}