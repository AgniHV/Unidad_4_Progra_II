using System;
public class Ejercicio_1_prueba{
    public static void Main(string[] args){
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        if(nombre.ToLower()== "david"){
            Console.WriteLine("Hola David");
        }
        else
        {
            Console.WriteLine("No te conozco");
            }
    }
}