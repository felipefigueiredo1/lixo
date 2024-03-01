namespace ConsoleApp1 // namespace define o caminho para encontrarmos essa classe.
{
    /*
     * Em C#, uma "internal class" é uma classe que só é acessível dentro do mesmo assembly 
     * (ou seja, o mesmo arquivo .dll ou .exe). 
     * Isso significa que outras classes fora do assembly 
     * não podem acessar diretamente uma classe interna.
     */
    internal class Program
    {
        /* O método Main é o ponto de entrada do programa
         * Ele precisa ser estático porque durante a compilação, o compilador não irá instanciar a classe
         * Ele apenas irá executar o método Main
         * Todo programa deve haver apenas 1 método Main
         */
        static void Main(string[] args) // Argumentos que são passados na execução do programa.
        {
            if(args.Length > 0) {
                Console.WriteLine(args[0]);
            }

            /* em C#, assim como na maioria das linguagens, o backslash aciona
            um caracter especial, que fará algum efeito na string que ele esta inserido,
            no exemplo abaixo "t" acrescenta varios espaços (tab), e "n" quebra a linha */

            Console.WriteLine("I\t like\t pizza\n!");
            // Isso é um comentário
            /* Isso também é um comentário */

            Console.ReadKey();
        }
    }
}
