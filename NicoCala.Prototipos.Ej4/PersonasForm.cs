namespace NicoCala.Prototipos.Ej4
{
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo = new();
        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            


            foreach(var persona in modelo.Personas)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = persona.Documento;
                fila.SubItems.Add(persona.Nombre);
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono);

                PersonasList.Items.Add(fila);
            }

        }
    }
}
