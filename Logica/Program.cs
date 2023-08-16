Console.WriteLine("Bem vindo ao APP PayBank\n");

Console.WriteLine("Olá Investidor bem vindo (a) digite o seu nome: ");
var nomeCliente = Console.ReadLine();

Console.Clear();
Console.WriteLine($"Digite agora o seu saldo: ");
double saldoInvestido = Convert.ToDouble(Console.ReadLine());

double taxaBanco = saldoInvestido * 0.05 / 100;

Console.Clear();
Console.WriteLine($"{nomeCliente} cobramos uma taxa de 0,05%, para fins de manutenção, deseja continuar?  digite S ou N");
var respostaTaxa = Console.ReadLine();
if (respostaTaxa == "s" || respostaTaxa == "S")
{
    double newSaldo = saldoInvestido - taxaBanco;

    Console.Clear();
    Console.WriteLine($"novo saldo em conta {newSaldo.ToString("0.00")} ");

    Console.WriteLine($"================================");

    Console.Clear();
    Console.WriteLine($"{nomeCliente}, deseja efetuar um saque? digite S ou N");
    var resposta = Console.ReadLine();

    if (resposta == "s" || resposta == "S")
    {
        Console.Clear();
        Console.WriteLine("Qual valor deseja sacar? ");
        double valorSaque = Convert.ToDouble(Console.ReadLine());
        if (valorSaque > newSaldo)
        {
            Console.Clear();
            Console.WriteLine($"Valor não permitido, o seu saldo é: R$ {newSaldo.ToString("0.00")}");
        }
        else
        {
            double newValor = newSaldo - valorSaque;

            Console.Clear();
            Console.WriteLine("\n==========          +++ Saque efetuado com sucesso... +++          ==========\n");

            Console.WriteLine($"{nomeCliente} o seu novo saldo é {newValor.ToString("0.00")} ");
            //O processo para usar duas casas decimais é utilizando o comando .ToString("0.00")
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Obrigado por usar o Programa");
    }
}
else
{
    Console.Clear();
    Console.WriteLine($"Que pena seria um prazer ter você como cliente, seu saldo de R$ {saldoInvestido.ToString("0.00")} será restituído.\n");

    Console.WriteLine($"Obrigado  por utilizar nossos serviços...");
}
Console.Read();
