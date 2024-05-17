namespace NicoCala.Prototipos.Ej4
{
    public class Telefono
    {
        public TipoTelefono Tipo { get; set; }
        public int CodPais { get; set; }
        public int CodArea { get; set; }
        public int Numero { get; set; }

        public string Descripcion()
        {
            return $"({Tipo}) +{CodPais:00} {CodArea:00} - {Numero:0000}";
        }
    }
}