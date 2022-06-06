// See https://aka.ms/new-console-template for more information
using AoCubo;




Cubo teste = new Cubo();

string entrada = Console.ReadLine();
int numero = int.Parse(entrada);

teste.Aocubo(ref numero);

Console.WriteLine($" O valor do cubo é {numero}.");








