namespace webapi.DB
{
    public class NewPersona
    {
        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Sexo { get; set; } = null!;

        public string Foto { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public string Cedula { get; set; } = null!;

        public string Comentario { get; set; } = null!;

    }
}
