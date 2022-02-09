using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo.entidades;

namespace modelo.operaciones
{
    public class CalcDiaPedidos
    {
        public int PedidosTotal(Inventario invetario)
        {
            
            int res= 0;
            if ( invetario.InicioPedido.Date.Day <= 10 && invetario.LimitePedido.Day>=0)
            {

                TimeSpan inicioPedido = new TimeSpan(1);
                TimeSpan limitePedido = new TimeSpan(10);

                TimeSpan dif = (invetario.InicioPedido.Date + limitePedido) - (invetario.InicioPedido.Date + inicioPedido);
                var difA = dif.TotalDays;
                res = ((int)difA);


            }
            else
            {
                TimeSpan limitePedido = new TimeSpan(10);
                TimeSpan dif = (invetario.LimitePedido.Day + limitePedido) - invetario.InicioPedido;
                var difA = dif.TotalDays;
                res = ((int)difA);



            }

            return res;
        }


    }
}
