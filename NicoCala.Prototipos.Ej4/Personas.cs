namespace NicoCala.Prototipos.Ej4
{
    public class Persona
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Telefono Telefono { get; set; }

        public void ActualizarCon(Persona datos)
        {
            Documento = datos.Documento;
            Nombre = datos.Nombre;
            Apellido = datos.Apellido;
            Telefono.ActualizarCon(datos.Telefono);
        }

        public string Validar()
        {
            if(Documento <999_999)
            {
                return "El documento debe tener al menos 7 cifras";
            }
            //solo utilizo mis propiedades

            if(string.IsNullOrWhiteSpace(Nombre))
            {
                return "El nombre no puede estar vacío.";
            }

            return null;
        }

    }
}