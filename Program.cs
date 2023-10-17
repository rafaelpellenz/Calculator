namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        int v1, v2;
        int operador = Menu();
        

        switch (operador)
        {
            case 1:
                Console.WriteLine("Digite o primeiro valor:");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine("A Soma de " + v1 + " e " + v2 + " é " + (v1+v2));
                break;
            case 2:
                Console.WriteLine("Digite o primeiro valor:");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine("A Subtração de " + v1 + " e " + v2 + " é " + (v1-v2));
                break;
            case 3:
                Console.WriteLine("Digite o primeiro valor:");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine("A Divisão de " + v1 + " e " + v2 + " é " + (v1/v2));
                break;
             case 4:
                Console.WriteLine("Digite o primeiro valor:");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine("A Multiplicação de " + v1 + " e " + v2 + " é " + (v1*v2));
                break;
        }
    }

    static int Menu()
    {
        Console.WriteLine("Digite o número da opção e tecle ENTER.");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        int operador = int.Parse(Console.ReadLine());

        if (operador > 4 || operador < 1)
        {
            Console.WriteLine("Valor invalido, digite novamente.");
            Menu();
        }

        Console.WriteLine("Você escolheu " + operador);

        return operador;
    }
}
