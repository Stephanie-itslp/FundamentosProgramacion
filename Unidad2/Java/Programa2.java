/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package ap.programa2;
import java.util.Scanner;
/**
 *
 * @author LTI2-00
 */
public class Programa2 { //PASO 1

    public static void main(String[] args) { //PASO1
        Scanner sc= new Scanner(System.in); //PASO1
        int a, b, suma; //PASO2-DECLARAR VARIABLES
        System.out.print("Escribe un número A: "); //PASO3-SOLICITAR
        a = sc.nextInt(); //PASO4- ASIGNAR VALOR
        System.out.println("Escribe un número B: "); //PASO3-SOLICITAR
        b = sc.nextInt(); //PASO4- ASIGNAR VALOR
        suma=a+b; //PASO5-OPERACION
        System.out.println("Resultado: "+suma); //PASO6- IMPRIMIR
    }
}
