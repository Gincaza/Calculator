class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        //Titulo
        Console.WriteLine("Calculadora de Console em C#\r");
        Console.WriteLine("------------------------------\n");

        while (!endApp)
        {
            //Declarar as variaiveis e deixar vazio
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            //Pergunte ao usuario pra escrever o num1
            Console.Write("Escreva um numero e pressione Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Insira um input valido: ");
                numInput1 = Console.ReadLine();
            }

            //Pergunta ao usuario o segundo numero
            Console.Write("Escreva um numero e pressione Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Insira um input valido: ");
                numInput2 = Console.ReadLine();
            }

            //Pergunta ao usuario para escolher um operador
            Console.WriteLine("Escolha um operador:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write(">? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Essa operacao vai causar em um erro.\n");
                }
                else
                {
                    Console.WriteLine("Seu resultado: {0:0.##}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um problema: " + e.Message);
            }

            //Esperar pelon usuario antes de fechar
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Pressione n e Enter para fechar o programa.");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); //Criando um espaco
        }
    }
}
class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                //Se preencher zero ele nao aceita
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
        }
        return result;
    }
}