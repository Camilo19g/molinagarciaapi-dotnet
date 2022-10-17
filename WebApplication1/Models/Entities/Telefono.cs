using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entities
{
    public partial class Telefono
    {
        public int Num { get; set; }
        public string Oper { get; set; } = null!;
        public int Duenio { get; set; }

        public virtual Persona DuenioNavigation { get; set; } = null!;
    }
}
