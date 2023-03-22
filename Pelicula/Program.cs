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
        
    }

    public class Actor
    {
        //Propiedades
        public string Nombre;
        public Int16 año;

        //Constructores
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
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
