using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
     public Pelicula(){}

     public Pelicula(string titulo,Int16 año)
     {
        this.titulo=titulo;
        this.año=año;
     }
     
        //Métodos
     public string GetTitulo()
     {return titulo;}
     
     public void SetTitulo(string titulo)
     {
        this.titulo=titulo;
        
     }
     public Int16 GetAño()
     {return año;}
     public void SetAño(Int16 año)
    {
        this.año=año;
        
    }
    public string GetPais()
    {return pais;}
    public void SetPais(string pais)
    {
    this.pais=pais;

    }
    public string GetDirector()
    {return director;}
    public void SetDirector(string director)
    {
        this.director=director;

    }


     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");

        }
           public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
            foreach(Actor persona in actores)
            {
                Console.WriteLine($"{persona.GetNombre()} ({persona.GetAño()})");
            }
            
    }
    }

    public class Actor
    {
        //Propiedades
     string Nombre;
     Int16 año;

        //Constructores
        public Actor()
        {}
public Actor (string Nactor,Int16 naciaño)
{
    Nombre=Nactor;
    año=naciaño;
}

        //Métodos 
    public string GetNombre()
    {return Nombre;}
    public void SetNombre(string nombres)
    {
        Nombre=nombres;
    }
    public Int16 GetAño()
    {return año;}
    
    public void SetAño(Int16 años)
    {
        año=años;
    }
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({año})");
        }

    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
         

               Pelicula p1 = new Pelicula();
               Pelicula p2 = new Pelicula();

               p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());
            p1.Imprime();
         List<Pelicula> repelis = new List<Pelicula>();

repelis.Add(new Pelicula ("The Joker",2019));
repelis.Add(new Pelicula ("Green Book",2018));


foreach(Pelicula movis in repelis)
{
movis.Imprime();
}
    p1.AgregaActor(new Actor("Ryan Gosling", 1980));
     p1.AgregaActor(new Actor("Emma Stone", 1988));

   p1.ImprimeActores();
  

        }
    
    }
    }
