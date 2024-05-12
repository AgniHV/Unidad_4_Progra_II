using System;

public class Ejercicio_6{
    public static void Main(string[] args){
         double suma =0;

         for (int i=0;i<5;i++){
            Console.WriteLine("Ingrese un numero:");
            suma += Convert.ToDouble(Console.ReadLine());
         }
         double promedio = suma/5;
         Console.WriteLine("El promedio de los numeros ingresados es: "+promedio);
    }
}