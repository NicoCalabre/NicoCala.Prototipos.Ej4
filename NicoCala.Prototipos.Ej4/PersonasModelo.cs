namespace NicoCala.Prototipos.Ej4
{
    internal class PersonasModelo
    {
        public List<Personas> Personas { get; set; }

        public PersonasModelo()
        {
            Personas = new List<Personas>
            {
                new Personas { Apellido = "Perez", Nombre = "Juan", Documento = 12345678, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 12345678 } },
                new Personas { Apellido = "Gomez", Nombre = "Maria", Documento = 23456789, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 23456789 } },
                new Personas { Apellido = "Lopez", Nombre = "Carlos", Documento = 34567890, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 34567890 } },
                new Personas { Apellido = "Rodriguez", Nombre = "Ana", Documento = 45678901, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 45678901 } },
                new Personas { Apellido = "Martinez", Nombre = "Luis", Documento = 56789012, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 56789012 } },
                new Personas { Apellido = "Garcia", Nombre = "Laura", Documento = 67890123, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 67890123 } },
                new Personas { Apellido = "Sanchez", Nombre = "Jose", Documento = 78901234, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 78901234 } },
                new Personas { Apellido = "Diaz", Nombre = "Lucia", Documento = 89012345, Telefono = new Telefono { Tipo = TipoTelefono.Otro, CodPais = 54, CodArea = 11, Numero = 89012345 } },
                new Personas { Apellido = "Fernandez", Nombre = "Miguel", Documento = 90123456, Telefono = new Telefono { Tipo = TipoTelefono.Trabajo, CodPais = 54, CodArea = 11, Numero = 90123456 } },
                new Personas { Apellido = "Ruiz", Nombre = "Marta", Documento = 12340123, Telefono = new Telefono { Tipo = TipoTelefono.Casa, CodPais = 54, CodArea = 11, Numero = 12340123 } }
            };

        }

    }
}