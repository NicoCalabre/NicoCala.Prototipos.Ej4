namespace NicoCala.Prototipos.Ej4
{
    public class PersonasModelo
    {
        public List<Persona> Personas { get; set; }
        public Persona? PersonaEnEdicion { get; set; }
        public Persona? PersonaEnEliminacion { get; set; }


        public PersonasModelo()
        {
            Personas = new List<Persona>
            {
                new Persona { Apellido = "Perez", Nombre = "Juan", Documento = 12345678, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 12345678 } },
                new Persona { Apellido = "Gomez", Nombre = "Maria", Documento = 23456789, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 23456789 } },
                new Persona { Apellido = "Lopez", Nombre = "Carlos", Documento = 34567890, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 34567890 } },
                new Persona { Apellido = "Rodriguez", Nombre = "Ana", Documento = 45678901, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 45678901 } },
                new Persona { Apellido = "Martinez", Nombre = "Luis", Documento = 56789012, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 56789012 } },
                new Persona { Apellido = "Garcia", Nombre = "Laura", Documento = 67890123, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 67890123 } },
                new Persona { Apellido = "Sanchez", Nombre = "Jose", Documento = 78901234, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 78901234 } },
                new Persona { Apellido = "Diaz", Nombre = "Lucia", Documento = 89012345, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 89012345 } },
                new Persona { Apellido = "Fernandez", Nombre = "Miguel", Documento = 90123456, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 90123456 } },
                new Persona { Apellido = "Ruiz", Nombre = "Marta", Documento = 12340123, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 12340123 } }
            };

        }

        public string Borrar(Persona personaBorrar)
        {
            Personas.Remove(personaBorrar);
            return null;
        }

        public string Nuevo(Persona nuevaPersona)
        {
            string error = nuevaPersona.Validar();
            if (error != null)
            {
                return error;
            }


            foreach (var personaExistente in Personas)
            {
                if (personaExistente.Documento == nuevaPersona.Documento)
                {
                    return "Ya existe una persona con el documento indicado.";
                }
            }
            Personas.Add(nuevaPersona);

            return null;
        }

        public string Modificar(Persona nuevosDatosPersona)
        {
            string error = nuevosDatosPersona.Validar();
            //validar a la persona
            if(error != null)
            {
                return error;
            }
            //validaciones que se realizan tanto para una modificación como para una edición
            //validaciones que se realizan en la modificación
            //no se puede modificar el dni

            if(PersonaEnEdicion.Documento != nuevosDatosPersona.Documento)
            {
                return "No se puede modificar el documento.";
            }
            //reemplaazar un objeto con otro, no siempre es valido
            //Personas.Remove(PersonaEnEdicion);
            //Personas.Add(datosIngresadosPersona);
            //siempre es valido pisar el objeto
            PersonaEnEdicion.ActualizarCon(nuevosDatosPersona);

            return null;
            
        }

    }
}