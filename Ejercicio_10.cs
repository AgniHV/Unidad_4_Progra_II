using System;
public class Ejercicio_10{
    public static void Main(string[] args){

        int sumaEdades = 0;

        for (int i=0; i<15; i++){
            Console.WriteLine("Ingrese la edad del estudiante "+(i+1)+ ":");
            sumaEdades +=Convert.ToInt32(Console.ReadLine());
        }

        double promedioEdades = (double)sumaEdades/15;
        Console.WriteLine("La edad promedio de los 15 estudiantes es: "+promedioEdades);
    }
}