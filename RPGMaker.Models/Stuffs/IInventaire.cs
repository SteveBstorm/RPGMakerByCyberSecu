using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Stuffs
{
    public interface IInventaire
    {
        List<Equipement> Inventaire { get; set; }
    }
}
