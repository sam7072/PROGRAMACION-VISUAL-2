using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Configuracion
    {
       public int PedidosTotales { get; set; }
       public string NombreDistribuidor { get; set; }
       public int DiasEntreMinimos { get; set;}
       public int LibrosMinimos { get; set;}

    }
}
