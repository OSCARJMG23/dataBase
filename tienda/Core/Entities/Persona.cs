using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona
    {
        public int Id {get; set;}
        public string ? IdPersona {get; set;}
        public string ? NombrePersona {get; set;}
        public DateTime FechaNac {get; set;}
        public int IdTipoPer {get; set;}
        public TipoPersona? TipoPersona {get;set;}
        public ICollection<Producto>Productos {get;set;} = new HashSet<Producto>();
        public ICollection<ProductoPersona>? ProductosPersonas {get;set;}
    }
}