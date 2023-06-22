// See https://aka.ms/new-console-template for more information
using AdminPersonal;
var fecha = DateTime.Now;
var EmpleadosEmpresa = new Empleado[3];
Empleado viejo;
EmpleadosEmpresa[0] = new Empleado("Juan", "Perez", new DateTime(1995, 04, 01), 'C', 'V', DateTime.Now, 21400, cargos.Investigador);
EmpleadosEmpresa[1] = new Empleado("Rodrigro", "Vizcarra", new DateTime(1996, 11, 23), 'S', 'V', new DateTime(2022, 04, 10), 35983.2, cargos.Auxiliar);
EmpleadosEmpresa[2] = new Empleado("Marta", "Legrand", new DateTime(1535, 09, 18), 'S', 'M', new DateTime(1940, 03, 01), 435980.655, cargos.Especialista);

for (int i = 0; i < EmpleadosEmpresa.Length; i++)
{
    Console.WriteLine($"El salario de Empleado{i} = {EmpleadosEmpresa[i].salario():N2}");
}
Console.WriteLine($"El total a pagar de salarios es de: {EmpleadosEmpresa[0].salario() + EmpleadosEmpresa[1].salario() + EmpleadosEmpresa[2].salario() :N2}\n");

if(EmpleadosEmpresa[0].aniosJubilacion() <= EmpleadosEmpresa[1].aniosJubilacion() && EmpleadosEmpresa[0].aniosJubilacion() <= EmpleadosEmpresa[2].aniosJubilacion())
{
    viejo = EmpleadosEmpresa[0];
}else if(EmpleadosEmpresa[1].aniosJubilacion() <= EmpleadosEmpresa[0].aniosJubilacion() && EmpleadosEmpresa[1].aniosJubilacion() <= EmpleadosEmpresa[2].aniosJubilacion())
{
    viejo = EmpleadosEmpresa[1];
}else{
    viejo = EmpleadosEmpresa[2];
}
Console.WriteLine($"El empleado más próximo a jubilarse es: {viejo.Nombre}, {viejo.Apellido}, nacido en: {viejo.FechaNacimiento:d}, Estado Civil: {(viejo.EstadoCivil == 'C' ? "Casado" : "Soltero")}, genero: {(viejo.Genero == 'M' ? "Mujer" : "Varon")}, Inicio a trabajar en: {viejo.FechaIngresoEmpresa.ToString("dd/MM/yyyy")}, su sueldo basico es de: {viejo.SueldoBasico}, su cargo es: {viejo.Cargo}\n\n Su antiguedad es de: {viejo.Antiguedad()} anios, su edad es de: {viejo.Edad()} anios, los anios que le faltan para jubilarse son: {viejo.aniosJubilacion()}, su salario es de: {viejo.salario()}");



// using Calculadoritas;
// var Calculadora1 = new Calculadora();
// int opcion;
// double numero;
// bool esNumero;
// do
// {
//     do
//     {
//         Console.WriteLine("Ingrese una operacion: \n  1: Sumar\n  2: Restar\n  3: Multiplicar\n  4: Dividir\n  5: Limpiar\n  0: Salir");
//         esNumero = int.TryParse(Console.ReadLine(), out opcion);
//     } while (!esNumero);
//     if(opcion == 5){
//         Calculadora1.Limpiar();
//         Console.WriteLine("\n*****\n");
//     }else if (opcion != 0){
//         do
//         {
//             Console.WriteLine("Ingrese el valor: ");
//             esNumero = double.TryParse(Console.ReadLine(), out numero);
//         } while (!esNumero);
//         switch(opcion){
//             case 1:
//                 Calculadora1.Sumar(numero);
//                 break;
//             case 2:
//                 Calculadora1.Restar(numero);
//                 break;
//             case 3:
//                 Calculadora1.Multiplicar(numero);
//                 break;
//             case 4:
//                 Calculadora1.Dividir(numero);
//                 break;
//         }
//         Console.WriteLine("\nEl resultado es: " + Calculadora1.Resultado() + "\n\n*****\n");
//     }
// } while (opcion != 0);

