double salario;
string nome;

Console.WriteLine("--- Aumento Salário ---");

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine()!;

Console.WriteLine($"Olá {nome}, Digite seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Tudo bem {nome}, seu salário é: {salario} ");

if (salario <= 500)
{
    salario  = salario * 1.20;
    Console.WriteLine($"Com o aumento, seu salário ficou: {salario}");
}
else
{
    salario = salario * 1.10;
    Console.WriteLine($"Com o aumento, seu salário ficou: {salario}");
}

