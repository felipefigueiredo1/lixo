namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // declarando uma variável do tipo inteira.
            x = 123; // inciando a variável x inserindo um valor nela.

            int y = 321; // declarando e iniciando uma variável.

            int z = x + y;

            int age = 21;

            double height = 300.5; // variável do tipo double para numeros decimais.

            bool alive = true; // variável do tipo booleana para definição de "true" ou "false".

            char symbol = '@'; // variável do tipo caracter
            String name = "Felipe"; // variável do tipo string ( aqui é uma classe )
            /*
             * Uma String em algumas linguagens é um array de caracteres
             * e em outras linguagens (C# incluso) é uma classe
             */


            // em c# a concatenação de strings se faz utilizando o simbolo de adição

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("your age is = " + age);
            Console.WriteLine("your height is = " + height + "cm");
            Console.WriteLine("are you alive = " + alive);
            Console.WriteLine("you symbol are = " + symbol);
            Console.WriteLine("your name are = " + name);
        }
    }
}
