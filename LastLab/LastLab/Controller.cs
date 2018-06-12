using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLab
{
    public static class Controller
    {
        private static List<BdD> basededatos;
       
        public static void Init()
        {
            basededatos = new List<BdD>(); 
        }
        public static List<BdD> GetBase()
        {
            return basededatos;
        }
        

    }
}
