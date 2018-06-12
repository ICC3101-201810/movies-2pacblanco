using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LastLab
{
    public static class Controller
    {
        private static List<Persona> basededatos;

        public static void Init()
        {
            basededatos = new List<Persona>();
        }
        public static List<Persona> GetBase()
        {
            return basededatos;
        }

        public static List<Persona> Buscar(string s,string rol)
        {
            List<Persona> newreturn = new List<Persona>();
            foreach (Persona actor in GetBase())
            {
                if (actor.rol == rol)
                {
                    if (actor.nombre == s)
                    {
                        newreturn.Add(actor);
                    }
                    if (actor.apellido == s)
                    {
                        newreturn.Add(actor);
                    }
                }
            }
            return newreturn;
        }


    }
}
