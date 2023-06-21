// See https://aka.ms/new-console-template for more information
using Calculadoritas;
var Calculadora1 = new Calculadora();
int opcion;
double numero;
bool esNumero;
do
{
    do
    {
        Console.WriteLine("Ingrese una operacion: \n  1: Sumar\n  2: Restar\n  3: Multiplicar\n  4: Dividir\n  5: Limpiar\n  0: Salir");
        esNumero = int.TryParse(Console.ReadLine(), out opcion);
    } while (!esNumero);
    if(opcion == 5){
        Calculadora1.Limpiar();
        Console.WriteLine("\n*****\n");
    }else if (opcion != 0){
        do
        {
            Console.WriteLine("Ingrese el valor: ");
            esNumero = double.TryParse(Console.ReadLine(), out numero);
        } while (!esNumero);
        switch(opcion){
            case 1:
                Calculadora1.Sumar(numero);
                break;
            case 2:
                Calculadora1.Restar(numero);
                break;
            case 3:
                Calculadora1.Multiplicar(numero);
                break;
            case 4:
                Calculadora1.Dividir(numero);
                break;
        }
        Console.WriteLine("\nEl resultado es: " + Calculadora1.Resultado() + "\n\n*****\n");
    }
} while (opcion != 0);