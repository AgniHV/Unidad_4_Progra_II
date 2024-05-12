using System;

public class Ejercicio_9{
    public static void Main(string[] args){

        Console.WriteLine("Ingrese un numero:");
        int num =Convert.ToInt32(Console.ReadLine());

        if (num % 2==0){
            Console.WriteLine("El numero es PAR");
        }
        else{
            Console.WriteLine("El numero es IMPAR");
        }
    }
}