using System;
using System.Collections.Generic;

namespace webapi.DB;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string Foto { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Cedula { get; set; } = null!;

    public string Comentario { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }
}
