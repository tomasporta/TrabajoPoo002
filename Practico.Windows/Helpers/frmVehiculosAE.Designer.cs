namespace Practico.Windows.Helpers
{
    partial class frmVehiculosAE
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboTipoVehiculo = new ComboBox();
            cboMarca = new ComboBox();
            cboColor = new ComboBox();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            txtPatente = new TextBox();
            pnlExtra = new Panel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Veh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 137);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 185);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Año";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 217);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 5;
            label6.Text = "Patente";
            // 
            // cboTipoVehiculo
            // 
            cboTipoVehiculo.FormattingEnabled = true;
            cboTipoVehiculo.Location = new Point(115, 8);
            cboTipoVehiculo.Name = "cboTipoVehiculo";
            cboTipoVehiculo.Size = new Size(121, 23);
            cboTipoVehiculo.TabIndex = 6;
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged_1;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(115, 55);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 7;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(115, 137);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(121, 23);
            cboColor.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(115, 88);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 9;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(115, 177);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 10;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(118, 222);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 11;
            // 
            // pnlExtra
            // 
            pnlExtra.Location = new Point(543, 44);
            pnlExtra.Name = "pnlExtra";
            pnlExtra.Size = new Size(200, 108);
            pnlExtra.TabIndex = 12;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(125, 334);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(278, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmVehiculosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(pnlExtra);
            Controls.Add(txtPatente);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(cboColor);
            Controls.Add(cboMarca);
            Controls.Add(cboTipoVehiculo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVehiculosAE";
            Text = "frmVehiculosAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboTipoVehiculo;
        private ComboBox cboMarca;
        private ComboBox cboColor;
        private TextBox txtModelo;
        private TextBox txtAño;
        private TextBox txtPatente;
        private Panel pnlExtra;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}