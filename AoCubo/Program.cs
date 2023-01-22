// See https://aka.ms/new-console-template for more information
using AoCubo;

ObjectoDeNegocio objectoDeNegocioCubo = new ObjectoDeNegocio(new Cubo());
ObjectoDeNegocio objectoDeNegocioQuadrado = new ObjectoDeNegocio(new Quadrado());

Console.WriteLine($" Digite um numero para saber seu resultado ao Cubo.");

string input = ConsoleExtensions.ReadWithOffset();
int number = int.Parse(input);

var resultCubo = objectoDeNegocioCubo.Calcular(number);
var resultQuadrado = objectoDeNegocioQuadrado.Calcular(number);

Console.WriteLine($" O valor do cubo é {resultCubo}...");
Console.WriteLine($" O valor do quadrado é {resultQuadrado}...");