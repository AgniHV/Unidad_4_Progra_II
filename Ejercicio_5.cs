using System;

public class Ejercicio_5{
    public static void Main(string[] args){

        Console.WriteLine("Ingrese el numero que desee para ver su tabla de multiplicar:");

        int num= Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=10; i++){
            Console.WriteLine(num +"x"+i+"="+(num*i));
        }
    }
}