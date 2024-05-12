using System;

public class Ejercicio_8{
    public static void Main(string[] args){

        Console.WriteLine("Ingrese el numero que desee evaluar:");
        int num=Convert.ToInt32(Console.ReadLine());

        if (num>0){
            Console.WriteLine("El numero es POSITIVO");
        }
        else if (num<0){
            Console.WriteLine("El numero es NEGATIVO");

        }
        else{
            Console.WriteLine("El numero ingresado es NULO O NEUTRO");
        }
    }
}