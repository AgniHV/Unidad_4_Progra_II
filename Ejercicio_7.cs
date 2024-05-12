using System;

public class Ejercicio_7{
    public static void Main(string[] args){

        Console.WriteLine("Ingrese un numero mayor que cero:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num>0){
            Console.WriteLine("El cuadrado de "+num+" es: "+(num*num));
        }
        else{
            Console.WriteLine("ERROR.Reingrese un numero.");
        }

    }
}