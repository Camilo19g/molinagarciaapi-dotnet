using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Entities
{
    public partial class Profesion
    {
        public Profesion()
        {
            Estudios = new HashSet<Estudio>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Des { get; set; } = null!;

        public virtual ICollection<Estudio> Estudios { get; set; }
    }
}
