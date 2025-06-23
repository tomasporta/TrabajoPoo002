using Practico.Datos;
using Practico.Entidades;
using Practico.Windows.Helpers;

namespace Practico.Windows
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();

        }
        private void MostrarDatosEnGrilla()
        {
            var lista = RepositorioVehiculosLinq.ObtenerTodos();
            GridHelpers.LimpiarGrilla(dgvDatos);

            foreach (Vehiculo v in lista)
            {
                var fila = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(fila, v, dgvDatos);
                GridHelpers.AgregarFila(fila, dgvDatos);
            }
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            var form = new frmVehiculosAE();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var vehiculo = form.GetVehiculo();
                if (RepositorioVehiculosLinq.Guardar(vehiculo))
                    MostrarDatosEnGrilla();
                else
                    MessageBox.Show("Veh�culo duplicado.");
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                string patente = dgvDatos.SelectedRows[0].Cells[4].Value.ToString();

                var resultado = MessageBox.Show(
                    $"�Est�s seguro de que quer�s eliminar el veh�culo con patente {patente}?",
                    "Confirmar eliminaci�n",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2 
                );

                if (resultado == DialogResult.Yes)
                {
                    if (RepositorioVehiculosLinq.Eliminar(patente))
                        MostrarDatosEnGrilla();
                    else
                        MessageBox.Show("Veh�culo no encontrado.");
                }
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccion� un veh�culo para editar.", "Atenci�n");
                return;
            }

            string patente = dgvDatos.SelectedRows[0].Cells[4].Value.ToString()!;
            Vehiculo? original = RepositorioVehiculosLinq.BuscarPorPatente(patente);
            if (original == null)
            {
                MessageBox.Show("Veh�culo no encontrado.");
                return;
            }

            var frm = new frmVehiculosAE();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Vehiculo modificado = frm.GetVehiculo()!;
                RepositorioVehiculosLinq.Eliminar(patente);
                RepositorioVehiculosLinq.Guardar(modificado);
                MostrarDatosEnGrilla();
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            MostrarDatosEnGrilla();
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            string tipoSeleccionado = cboFiltroTipo.SelectedItem?.ToString();

            List<Vehiculo> listaFiltrada = tipoSeleccionado == "Todos"
                ? RepositorioVehiculosLinq.ObtenerTodos()
                : RepositorioVehiculosLinq.ListarPorTipo(tipoSeleccionado);

            GridHelpers.LimpiarGrilla(dgvDatos);

            foreach (Vehiculo v in listaFiltrada)
            {
                var fila = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(fila, v, dgvDatos);
                GridHelpers.AgregarFila(fila, dgvDatos);
            }
        }

        private void frmVehiculos_Load_1(object sender, EventArgs e)
        {
            cboFiltroTipo.Items.AddRange(new[] { "Todos", "Auto", "Camioneta", "Moto", "A�o" });
            cboFiltroTipo.SelectedIndex = 0;
            cboOrdenA�o.Items.Clear();
            cboOrdenA�o.Items.Add("Ascendente");
            cboOrdenA�o.Items.Add("Descendente");
            cboOrdenA�o.SelectedIndex = 0;
            MostrarDatosEnGrilla();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string patente = txtBuscarPatente.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Ingres� una patente para buscar.", "Atenci�n");
                return;
            }

            Vehiculo? vehiculo = RepositorioVehiculosLinq.BuscarPorPatente(patente);

            GridHelpers.LimpiarGrilla(dgvDatos);

            if (vehiculo != null)
            {
                var fila = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(fila, vehiculo, dgvDatos);
                GridHelpers.AgregarFila(fila, dgvDatos);
            }
            else
            {
                MessageBox.Show($"No se encontr� ning�n veh�culo con patente: {patente}.", "Sin resultados");
            }
        }

        private void cboFiltroTipo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var lista = RepositorioVehiculosLinq.ObtenerTodos();

            string orden = cboOrdenA�o.SelectedItem?.ToString();

            List<Vehiculo> listaOrdenada = orden == "Ascendente"
                ? lista.OrderBy(v => v.Anio).ToList()
                : lista.OrderByDescending(v => v.Anio).ToList();

            GridHelpers.LimpiarGrilla(dgvDatos);

            foreach (Vehiculo v in listaOrdenada)
            {
                var fila = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(fila, v, dgvDatos);
                GridHelpers.AgregarFila(fila, dgvDatos);
            }
        }
    }
}
   

