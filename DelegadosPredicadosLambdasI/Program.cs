using System;

namespace DelegadosPredicadosLambdasI
{
    class Program
    {
        static void Main(string[] args)
        {   //creacion del objeto delegado
            //Se llama al delegado, se hace refencia a la clase que debe ser del mismo tipo y al metodo
            ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludosBienvenida);
            //utilizacion del delegado para llamar al metodo saludo bienvenida
            elDelegado();

            elDelegado = new ObjetoDelegado(MensajeDespedida.SaludosDespedida);

            elDelegado();
            
        }
        //Los delegados apunta a los metodos, incluso en clases diferentes, ficheros independientes
        //es capaz de hacer referencia a un metodo en diferntes archivos clase etc
        //definicion de objeto delegado
        delegate void ObjetoDelegado();

    }

   


    class MensajeBienvenida
    {
        public static void SaludosBienvenida()
        {
            Console.WriteLine("Hola acabo de llegar");
        }
    }

    class MensajeDespedida
    {
        public static void SaludosDespedida()
        {
            Console.WriteLine("Hola tengo que  de irme");
        }
    }
}
