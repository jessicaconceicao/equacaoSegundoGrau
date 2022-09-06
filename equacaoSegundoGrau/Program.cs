//Dados valores de "a", "b" e "c", encontre as raízes da equação de segundo grau
using equacaoSegundoGrau;

int a, b, c;
double delta, raizDeDelta, primeiraRaiz, segundaRaiz;

Console.WriteLine("Digite o valor de a");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Digite o valor de b");
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Digite o valor de c");
int.TryParse(Console.ReadLine(), out c);

delta = Math.Pow(b, 2) - (4 * a * c);

raizDeDelta = Math.Sqrt(delta);

primeiraRaiz = (-b + raizDeDelta) / (2 * a);
segundaRaiz = (-b - raizDeDelta) / (2 * a);

var verificaPrimeiraRaiz = new IsNaN();
var verificaSegundaRaiz = new IsNaN();

Console.WriteLine($"Primeira raiz: {verificaPrimeiraRaiz.VerifyNaN(primeiraRaiz)} | Segunda raiz: {verificaSegundaRaiz.VerifyNaN(segundaRaiz)};");


