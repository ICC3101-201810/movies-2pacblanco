using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LastLab
{
    public class Persona 
    {
        public string nombre, apellido, fechanac, biografia, rol; //rol es director, productor o actor
        
        public Persona(string nombre, string apellido, string fechanac, string biografia, string rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechanac = fechanac;
            this.biografia = biografia;
            this.rol = rol;
        }
    }

    public class Estudio 
    {
        public string nombre, direc, fechanac;

        public Estudio(string nombre, string direc, string fechanac)
        {
            this.nombre = nombre;
            this.direc = direc;
            this.fechanac = fechanac;
        }
    }
    public class Pelicula 
    {
        public string nombre, fechaestreno, descripcion, presupuesto;
        public Persona director;
        public Estudio estudio;

        public Pelicula(string nombre, Persona director, Estudio estudio, string fechaestreno, string descripcion, string presupuesto)
        {
            this.nombre = nombre;
            this.fechaestreno = fechaestreno;
            this.director = director;
            this.estudio = estudio;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
        }
    }
    public class PeliculaActor 
    {
        public Pelicula pelicula;
        public Persona actor;

        public PeliculaActor(Pelicula pelicula, Persona actor) 
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
    public class PeliculaProductor
    {
        public  Pelicula pelicula;
        public Persona productor;

        public PeliculaProductor(Pelicula pelicula, Persona productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }

}
