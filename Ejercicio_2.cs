using System;

public class Ejercicio_2{
    public static void Main(string[] args){
        int suma = 0;
        int numero;

        do
        {
            Console.WriteLine("Ingrese un numero positivo o cero para terminar:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0){
                suma +=numero;
            }
        }while (numero > 0);

        Console.WriteLine("la suma de los numeros positivos es: "+suma);
    }
}