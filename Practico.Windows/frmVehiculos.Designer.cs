namespace Practico.Windows
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            cboFiltroTipo = new ToolStripComboBox();
            tsbFiltrar = new ToolStripButton();
            txtBuscarPatente = new ToolStripTextBox();
            toolStripButton1 = new ToolStripLabel();
            cboOrdenAño = new ToolStripComboBox();
            dgvDatos = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            ColModelo = new DataGridViewTextBoxColumn();
            ColAño = new DataGridViewTextBoxColumn();
            ColPatente = new DataGridViewTextBoxColumn();
            ColColor = new DataGridViewTextBoxColumn();
            ColExtra = new DataGridViewTextBoxColumn();
            ColCosto = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbBorrar, tsbActualizar, cboFiltroTipo, tsbFiltrar, txtBuscarPatente, toolStripButton1, cboOrdenAño });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(62, 22);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(57, 22);
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(59, 22);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 22);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // cboFiltroTipo
            // 
            cboFiltroTipo.Name = "cboFiltroTipo";
            cboFiltroTipo.Size = new Size(121, 25);
            cboFiltroTipo.Click += cboFiltroTipo_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(23, 22);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // txtBuscarPatente
            // 
            txtBuscarPatente.Name = "txtBuscarPatente";
            txtBuscarPatente.Size = new Size(40, 25);
            txtBuscarPatente.Click += tsbBuscar_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(74, 22);
            toolStripButton1.Text = "<=Buscar";
            // 
            // cboOrdenAño
            // 
            cboOrdenAño.Name = "cboOrdenAño";
            cboOrdenAño.Size = new Size(114, 25);
            cboOrdenAño.Text = "Ordenar Por Año";
            cboOrdenAño.Click += toolStripButton1_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colMarca, ColModelo, ColAño, ColPatente, ColColor, ColExtra, ColCosto });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 25);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(800, 425);
            dgvDatos.TabIndex = 1;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            // 
            // colMarca
            // 
            colMarca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            // 
            // ColModelo
            // 
            ColModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColModelo.HeaderText = "Modelo";
            ColModelo.Name = "ColModelo";
            // 
            // ColAño
            // 
            ColAño.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAño.HeaderText = "Año";
            ColAño.Name = "ColAño";
            // 
            // ColPatente
            // 
            ColPatente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPatente.HeaderText = "Patente";
            ColPatente.Name = "ColPatente";
            // 
            // ColColor
            // 
            ColColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColColor.HeaderText = "Color";
            ColColor.Name = "ColColor";
            // 
            // ColExtra
            // 
            ColExtra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColExtra.HeaderText = "Extra";
            ColExtra.Name = "ColExtra";
            // 
            // ColCosto
            // 
            ColCosto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCosto.HeaderText = "Costo";
            ColCosto.Name = "ColCosto";
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(toolStrip1);
            Name = "frmVehiculos";
            Text = "Vehiculos";
            Load += frmVehiculos_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbActualizar;
        private DataGridView dgvDatos;
        private ToolStripComboBox cboFiltroTipo;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn ColModelo;
        private DataGridViewTextBoxColumn ColAño;
        private DataGridViewTextBoxColumn ColPatente;
        private DataGridViewTextBoxColumn ColColor;
        private DataGridViewTextBoxColumn ColExtra;
        private DataGridViewTextBoxColumn ColCosto;
        private ToolStripTextBox txtBuscarPatente;
        private ToolStripComboBox cboOrdenAño;
        private ToolStripButton tsbFiltrar;
        private ToolStripLabel toolStripButton1;
    }
}
