using System.Reflection;

namespace NicoCala.Prototipos.Ej4
{
    //Corregir cambio de nombre de clase Personas a Persona !!! odio todo
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo = new();


        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {



            CargarLista();

        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (PersonasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }


            var personaAEditar = (Persona)PersonasList.SelectedItems[0].Tag;
            modelo.PersonaEnEdicion = personaAEditar;

            var formEdicion = new PersonaEditarForm();
            formEdicion.Modelo = modelo;
            formEdicion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre

            CargarLista();
        }


        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            var formNuevo = new PersonaNuevoForm();
            formNuevo.Modelo = modelo;
            formNuevo.ShowDialog();
            //la ejecución se detiene en esta linea y continua solo que una vez el formulario se haya cerrado

            CargarLista();
        }

        private void CargarLista()
        {
            PersonasList.Items.Clear();

            foreach (var persona in modelo.Personas)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = persona.Documento.ToString();
                fila.SubItems.Add(persona.Nombre);
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono.Descripcion());
                fila.Tag = persona;
                PersonasList.Items.Add(fila);
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            var personaAEliminar = (Persona)PersonasList.SelectedItems[0].Tag;
            modelo.Borrar(personaAEliminar);
            CargarLista();
        }
    }
}
