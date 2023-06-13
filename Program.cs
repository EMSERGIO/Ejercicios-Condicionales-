using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            // int n1, n2, calcular;

            // Console.WriteLine("Ingrese el primer numero:");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero:");
            // n2 = int.Parse(Console.ReadLine());

            // if(n1 > n2){
            //     calcular = n1 - n2;
            //     Console.WriteLine("El resultado de la resta es:" + calcular);
            // }else if(n1 == n2){
            //     calcular = n1 + n2;
            //     Console.WriteLine("El resultado de la suma es:" + calcular);
            // }else if(n1 < n2){
            //     calcular = n1 * n2;
            //     Console.WriteLine("El resultado del producto es:" + calcular);
            // }
            
            // Console.WriteLine("FIN DEL PROGRAMA");

            //......................................................................

            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            // de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la 
            // cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

            // float litros, importeTotal;
            
            // Console.WriteLine("Cuanto fue el importe total gastado?");
            // importeTotal= float.Parse(Console.ReadLine());
            // Console.WriteLine("Que cantidad de litros compro?");
            // litros = float.Parse(Console.ReadLine());

            // if(litros <= 100){
            //     Console.WriteLine("NO TIENE DESCUENTO");
            //     Console.WriteLine("Su total a pagar es:" + importeTotal);
            // }else if(litros > 100 && litros <= 300){
            //     Console.WriteLine("SU DESDUENTO ES DEL 10%");
            //     importeTotal = importeTotal * 90 / 100;
            //     Console.WriteLine("Su total a pagar es: $" + importeTotal);
            // }else if(litros > 300 && litros <= 500){
            //     Console.WriteLine("SU DESCUENTO ES DEL 15%");
            //     importeTotal = importeTotal * 85 / 100;
            //     Console.WriteLine("Su total a pagar es: $ " + importeTotal);
            // }else if(litros > 500){
            //     Console.WriteLine("SU DESCUENTO ES DEL 25%");
            //     importeTotal = importeTotal * 75 / 100;
            //     Console.WriteLine("Su total a pagar es: $" + importeTotal);
            // }

            // Console.WriteLine("Usted lleva " + litros + "Ltrs.");

 
          //.............................. ........................................
            
            // 3. Una importante marca de computadoras permite elegir cierta configuración 
            //del equipo a comprar. Para ello existe la siguiente escala de precios:

            // Además, el equipo viene con un disco que permite almacenar 500 GB de información 
            // y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional
            // de USD 300. Hacer un programa que solicite la opción de procesador, 
            // la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender 
            // y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

            //              i5  (1)	    i7  (2)	    i9  (3)
            // 8 RAM  (1)	USD 800	    USD 900	    USD 1200
            // 16 RAM (2)	USD 900	    USD 1000	USD 1400
            // 32 RAM (3)	USD 1000	USD 1400	USD 2000

            // int ram, procesador, disco, montoTotal;

            // Console.WriteLine("Ingrese que capacidad de memoria RAM desea: ");
            // ram = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese que procesador decea: ");
            // procesador = int.Parse(Console.ReadLine());

            // switch (ram){
            //     case 1:
            //         switch (procesador)
            //         {
            //             case 1:
            //                 Console.WriteLine("8RAM/PROC.i5, el total es: USD 800");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 800 + 300;
            //                     Console.WriteLine("8RAM/PROC.i5/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("8RAM/PROC.i5, el total es: USD 800");
            //                 }
            //             break;
            //             case 2:
            //                 Console.WriteLine("8RAM/PROC.i7, el total es: USD 900");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 900 + 300;
            //                     Console.WriteLine("8RAM/PROC.i7/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("8RAM/PROC.i7, el total es: USD 900");
            //                 }
            //             break;
            //             case 3:
            //                 Console.WriteLine("8RAM/PROC.i9, el total es: USD 1200");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 1200 + 300;
            //                     Console.WriteLine("8RAM/PROC.i9/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("8RAM/PROC.i9, el total es: USD 900");
            //                 }
            //             break;
            //         }
            //     break;
            //     case 2:
            //         switch (procesador)
            //         {
            //             case 1:
            //                 Console.WriteLine("16RAM/PROC.i5, el total es: USD 900");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 900 + 300;
            //                     Console.WriteLine("16RAM/PROC.i5/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("16RAM/PROC.i5, el total es: USD 900");
            //                 }
            //             break;
            //             case 2:
            //                 Console.WriteLine("16RAM/PROC.i7, el total es: USD 1000");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 1000 + 300;
            //                     Console.WriteLine("16RAM/PROC.i7/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("16RAM/PROC.i7, el total es: USD 1000");
            //                 }
            //             break;
            //             case 3:
            //                 Console.WriteLine("16RAM/PROC.i9, el total es: USD 1400");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 1400 + 300;
            //                     Console.WriteLine("16RAM/PROC.i9/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("16RAM/PROC.i9, el total es: USD 1400");
            //                 }
            //             break;
            //         }

            //     break;
            //     case 3:
            //         switch (procesador)
            //         {
            //            case 1:
            //                 Console.WriteLine("32RAM/PROC.i5, el total es: USD 1000");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 1000 + 300;
            //                     Console.WriteLine("32RAM/PROC.i5/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("32RAM/PROC.i5, el total es: USD 1000");
            //                 }
            //            break;
            //            case 2:
            //                 Console.WriteLine("32RAM/PROC.i7, el total es: USD 1400");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 1400 + 300;
            //                     Console.WriteLine("32RAM/PROC.i7/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("32RAM/PROC.i7, el total es: USD 1400");
            //                 }
            //            break;
            //            case 3:
            //                 Console.WriteLine("32RAM/PROC.i9, el total es: USD 2000");
            //                 Console.WriteLine("QUIERE AMPLIAR SU DISCO DE 500MG A 1T POR USD 300 MAS? indique (1)SI / (2)NO");
            //                 disco = int.Parse(Console.ReadLine());
            //                 if(disco == 1){
            //                     montoTotal = 2000 + 300;
            //                     Console.WriteLine("32RAM/PROC.i9/1T, el total es:" + montoTotal);
            //                 }else{
            //                     Console.WriteLine("32RAM/PROC.i9, el total es: USD 2000");
            //                 }
            //            break;
            //         }
            //     break;    
            // }

            
            
            //......................................................................

            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma
            //  de los dos primeros es mayor al producto del segundo con el tercero.

            // int n1, n2, n3, suma, producto;

            // Console.WriteLine("Ingrese el primer numero:");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero:");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tercer numero:");
            // n3 = int.Parse(Console.ReadLine());

            // suma = n1 + n2;
            // producto = n2 * n3;

            // if(suma > producto){
            //     Console.WriteLine("El resultado de la suma es: " + suma + " es mayor del resultado del producto:" + producto);
            // }else{
            //     Console.WriteLine("El resultado de la suma es: " + suma + ", NO es MAYOR del resultado del producto:" + producto);
            // }


            //......................................................................
            


            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si
            //  los mismos se encuentran ordenados de forma decreciente .

            // int n1, n2, n3, n4;

            // Console.WriteLine("Ingrese el primer numero:");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero:");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tercer numero:");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el cuanto numero:");
            // n4 = int.Parse(Console.ReadLine());

            // if(n1 > n2 && n2 > n3 && n3 > n4){
            //     Console.WriteLine("Los numeros estan ordenados de manera decreciente");
            // }else{
            //     Console.WriteLine("Los numeros NO estan ordenados de manera decreciente");
            // }




        }
    }
}
