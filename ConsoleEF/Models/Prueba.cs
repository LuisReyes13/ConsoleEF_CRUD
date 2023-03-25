using System;
using System.Collections.Generic;

namespace ConsoleEF.Models;

public partial class Prueba
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public string Correo { get; set; } = null!;
}
