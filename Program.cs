// Este programa cria uma hierarquia de classes representando formas geométricas.
// A classe base 'FormaGeometrica' define os métodos genéricos para calcular a área
// e o perímetro de qualquer forma geométrica. As classes derivadas, como 'Quadrado',
// 'Círculo' e 'Triângulo', herdam de 'FormaGeometrica' e implementam suas versões
// específicas desses cálculos, considerando suas propriedades particulares.
// A ideia é fornecer uma estrutura flexível e extensível para o trabalho com diferentes
// tipos de formas geométricas, facilitando a reutilização de código e a manutenção.

using GeometriaHeranca;

Quadrado quadrado = new Quadrado();
quadrado.Lado = 71.54;

Console.WriteLine("Quadrado:");
Console.WriteLine($"Área: {quadrado.CalcularArea()}");
Console.WriteLine($"Perímetro: {quadrado.CalcularPerimetro()}");

Circulo circulo = new Circulo();
circulo.Raio = 80.40;

Console.WriteLine("\nCírculo:");
Console.WriteLine($"Área: {circulo.CalcularArea()}");
Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");

Triangulo triangulo = new Triangulo();
triangulo.Base = 38.41;
triangulo.Altura = 71.95;

Console.WriteLine("\nTriângulo:");
Console.WriteLine($"Área: {triangulo.CalcularArea()}");
Console.WriteLine($"Perímetro: {triangulo.CalcularPerimetro()}");