using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL.Modules
{
    public class Service
    {
        public Mawine Search(Project project, int GosNomer)
        {
            foreach (Mawine item in project.Mawines)
            {
                if (item.GosNomer == GosNomer)
                {
                    return item;
                }
            }
            return null;
        }
        public Mawine Search(Project project, string Model)
        {
            foreach (Mawine item in project.Mawines)
            {
                if (item.Model.ToLower() == Model.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
