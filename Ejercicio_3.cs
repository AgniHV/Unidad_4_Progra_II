using System;

public class Ejercicio_3{
    public static void Main(string[] args){

        string [] nombres = new string[5];
        double [] sueldos =new double[5];
        string nombreMayor = "";
        double sueldoMayor = 0;

        for(int i=0; i<5; i++){
            Console.WriteLine("Ingrese el nombre del operario:");
            nombres[i]= Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
           sueldos [i]=Convert.ToDouble(Console.ReadLine());

            if (sueldos[i]> sueldoMayor){
                sueldoMayor =sueldos[i];
                nombreMayor = nombres[i];
            }
        }

        Console.WriteLine("El operario con el sueldo mayor es: "+nombreMayor + "con un sueldo de $"+sueldoMayor);
    }
}