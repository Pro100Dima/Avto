using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL.Modules
{
    public enum Parts {Engine = 1, KPP, Transmission }
    public class Component
    {
        public Component(){}
        public Parts NameComponent { get; set; }
        public int IdComponent { get; set; }
    }
}
