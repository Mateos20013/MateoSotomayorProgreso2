using MateoSotomayorProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateoSotomayorProgreso2.Interfaces
{
    public class IRecarga
    {
        
            List<Recarga> DevuelveListRecarga();
            Recarga DevuelveRecarg(int Id);
            Boolean CrearRecarga(Recarga recarga);
      
    }
}
