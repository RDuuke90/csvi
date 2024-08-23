package com.example;

import java.util.Random;

public class Main {
    public static void main(String[] args) {
    
        /**
            Crea un programa que genere 10 numeros aleatorios entre 1 y 50, los almacene en un vector y luego encuentre el número mayor utilizando un bucle while.
        */

        Random random = new Random();
        //int aleatorio = random.nextInt(10); // 0 - 9
        //int aleatorio = random.nextInt(10) + 1; // 1 - 10

        int[] numeros = new int[10]; //[0][0][0][0][0][0][0][0][0][0]
                                     // 0  1  2  3  4  5  6  7  8  9  10
        //                      10
        for(int i = 0; i < numeros.length; i++){
            // i = 0      r = ? [1, 50]
            int r = random.nextInt(50) + 1; // 1 - 50
            numeros[i] = r; 
            System.out.println("i = "+i+" r = " + r);
        }
        //[4][12][32][45][6][10][20][46][23][11]
        // 0  (1)  2   3  4   5   6   7   8   9  
        int sum = 1;
        int mayor = numeros[0];
        while (sum < numeros.length) {

            //  4          12
            System.out.println("mayor: "+mayor+ " next: "+numeros[sum]);
            if(mayor < numeros[sum]){
                mayor = numeros[sum];
            }
            sum++;
        }
        System.out.println("El numero mayor es: "+mayor);
        //........

        /**
            Crea un programa que genere 10 numeros aleatorios entre 1 y 50, Que me sume cuantos numeros impares y pares se generaron. Al final imprimir cual de los tuvo mayor cantidad. Usando un ciclo while
        */
        int global = 0;
        int par = 0, impar = 0;
        
        // continue y break;
        // continue = Pasa al siguiente loop y omite el resto del codigo
        // break = Finaliza el loop por completo

        while( global < 10){
            int numero_aleatorio = random.nextInt(50) + 1;
            System.out.println(numero_aleatorio); // Informacion
            if (numero_aleatorio % 2 == 0){
                par += 1;
                global++;
                continue;
            } 
            impar = impar + 1;
            global++;
        }
        
        System.out.println("P: "+par+" Im: "+impar );
        if(par > impar){
            System.out.println("Par");
        } else if(impar > par) {
            System.out.println("Impar");
        } else {
            System.out.println("Empate");  
        }

        int loops = 0;
        while(true){
            int numero_aleatorio = random.nextInt(10) + 1;
            System.out.println(numero_aleatorio); // Informacion
            if (numero_aleatorio == 10){
                break;
            } 
            loops++;
        }
        System.out.println("l: "+loops); // Informacion

    }
}
