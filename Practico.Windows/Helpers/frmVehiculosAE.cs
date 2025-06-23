using Practico.Entidades;
using Practico.Utilidades;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Color = Practico.Entidades.Color;

namespace Practico.Windows.Helpers
{
    public partial class frmVehiculosAE : Form
    {
        private Vehiculo? vehiculo;
        public frmVehiculosAE()
        {
            InitializeComponent();
            InicializarCombos();
        }

        private void InicializarCombos()
        {
            cboTipoVehiculo.Items.AddRange(new[] { "Auto", "Camioneta", "Moto" });
            cboMarca.DataSource = Enum.GetValues(typeof(Marca));
            cboColor.DataSource = Enum.GetValues(typeof(Color));
            cboTipoVehiculo.SelectedIndexChanged += cboTipoVehiculo_SelectedIndexChanged;
        }

        private void cboTipoVehiculo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            pnlExtra.Controls.Clear();
            switch (cboTipoVehiculo.SelectedItem?.ToString())
            {
                case "Auto":
                    CrearCampoExtra("Cantidad de Puertas", "txtPuertas");
                    break;
                case "Camioneta":
                    CrearCampoExtra("Capacidad de Carga (kg)", "txtCarga");
                    break;
                case "Moto":
                    CrearCampoExtra("Cilindrada (cc)", "txtCilindrada");
                    break;
            }
        }

        private void CrearCampoExtra(string label, string nombreCaja)
        {
            pnlExtra.Controls.Add(new System.Windows.Forms.Label { Text = label, AutoSize = true, Top = 5, Left = 5 });
            pnlExtra.Controls.Add(new TextBox { Name = nombreCaja, Top = 25, Left = 5, Width = 150 });
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cboTipoVehiculo.SelectedItem?.ToString() ?? "";
                string modelo = txtModelo.Text.Trim();
                int anio = int.Parse(txtAño.Text);
                string patente = txtPatente.Text.Trim().ToUpper();
                Marca marca = (Marca)cboMarca.SelectedItem!;
                Color color = (Color)cboColor.SelectedItem!;

                Vehiculo v = tipo switch
                {
                    "Auto" => new Moto
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        Patente = patente,
                        Color = color,
                        CantPuertas = int.Parse(ControlesExtra("txtPuertas").Text)
                    },
                    "Camioneta" => new Camioneta
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        Patente = patente,
                        Color = color,
                        CapacidadCarga = int.Parse(ControlesExtra("txtCarga").Text)
                    },
                    "Moto" => new Moto
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        Patente = patente,
                        Color = color,
                        Cilindrada = int.Parse(ControlesExtra("txtCilindrada").Text)
                    },
                    _ => throw new InvalidOperationException("Tipo inválido.")
                };

                var contexto = new ValidationContext(v);
                var resultados = new List<ValidationResult>();
                if (!ValidadorPatente.EsValida(patente, anio, out string? errorPatente))

                {
                    MessageBox.Show(errorPatente, "Error de patente");
                    return;
                }

                vehiculo = v;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el vehículo: " + ex.Message);
            }
        }

        private TextBox ControlesExtra(string nombre) =>
            pnlExtra.Controls.OfType<TextBox>().First(t => t.Name == nombre);

        public Vehiculo? GetVehiculo() => vehiculo;


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTipoVehiculo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
