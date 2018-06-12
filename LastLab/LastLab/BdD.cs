using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLab
{

    public class BdD
    {

    }
    public class Persona : BdD
    {
        string nombre, apellido, fechanac, biografia, rol; //rol es director, productor o actor
        
        public Persona(string nombre, string apellido, string fechanac, string biografia, string rol):base()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechanac = fechanac;
            this.biografia = biografia;
            this.rol = rol;
        }
    }

    public class Estudio : BdD
    {
        string nombre, direc, fechanac;

        public Estudio(string nombre, string direc, string fechanac):base()
        {
            this.nombre = nombre;
            this.direc = direc;
            this.fechanac = fechanac;
        }
    }
    public class Pelicula : BdD
    {
        string nombre, fechaestreno, descripcion, presupuesto;
        Persona director;
        Estudio estudio;

        public Pelicula(string nombre, Persona director, Estudio estudio, string fechaestreno, string descripcion, string presupuesto): base()
        {
            this.nombre = nombre;
            this.fechaestreno = fechaestreno;
            this.director = director;
            this.estudio = estudio;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
        }
    }
    public class PeliculaActor : BdD
    {
        Pelicula pelicula;
        Persona actor;

        public PeliculaActor(Pelicula pelicula, Persona actor) : base()
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
    public class PeliculaProductor: BdD
    {
        Pelicula pelicula;
        Persona productor;

        public PeliculaProductor(Pelicula pelicula, Persona productor):base()
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }

}
