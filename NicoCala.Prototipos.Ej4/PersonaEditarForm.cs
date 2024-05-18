using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicoCala.Prototipos.Ej4
{
    public partial class PersonaEditarForm : Form
    {
        public PersonasModelo Modelo { get; set; }
        public PersonaEditarForm()
        {
            InitializeComponent();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarBoton_Click(object sender, EventArgs e)
        {
            //VALIDAR
            if (!int.TryParse(DocumentoText.Text, out var doc))
            {
                MessageBox.Show("El documento no es válido");
                return;
            }
            //etc..
            //if (!Enum.TryParse<TipoTelefono>(TipoCombo.Text, out var tipoTelefono))
            //{
            //    MessageBox.Show("El tipo de telefono no es válido");
            //    return;
            //}
            Persona persona = new()
            {
                Documento = doc,
                Apellido = ApellidoText.Text,
                Nombre = NombreText.Text,
                Telefono = new Telefono
                {
                    Tipo = Enum.Parse<TipoTelefono>(TipoCombo.Text),
                    CodPais = int.Parse(CodPaisText.Text),
                    CodArea = int.Parse(CodAreaText.Text),
                    Numero = int.Parse(NumeroText.Text)
                }
            };

            string error = Modelo.Modificar(persona);
            if(error != null)// esto es un fi?
            {
                MessageBox.Show(error);
                return;
            }
            this.Close();

        }


        private void PersonaEditarForm_Load(object sender, EventArgs e)
        {

            TipoCombo.Items.Add(TipoTelefono.Casa.ToString());
            TipoCombo.Items.Add(TipoTelefono.Trabajo.ToString());
            TipoCombo.Items.Add(TipoTelefono.Otro.ToString());

            DocumentoText.Text = Modelo.PersonaEnEdicion.Documento.ToString();
            ApellidoText.Text = Modelo.PersonaEnEdicion.Apellido;
            NombreText.Text = Modelo.PersonaEnEdicion.Nombre;

            TipoCombo.SelectedItem = Modelo.PersonaEnEdicion.Telefono.Tipo.ToString();
            CodAreaText.Text = Modelo.PersonaEnEdicion.Telefono.CodArea.ToString();
            CodPaisText.Text = Modelo.PersonaEnEdicion.Telefono.CodPais.ToString();
            NumeroText.Text = Modelo.PersonaEnEdicion.Telefono.Numero.ToString();


        }
    }
}
