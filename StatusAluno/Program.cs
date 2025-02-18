namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um algoritmo para a leitura de duas notas parciais 
             * de um aluno.
             * O algoritmo deve calcular a média alcançada por aluno 
             * e apresentar:
            
                A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
                A mensagem "Reprovado", se a média for menor do que cinco;
                A mensagem “Recuperação", se a média estiver entre cinco e sete.
            */
            double nota1 = 0;
            double nota2 = 0;
            string mensagem = "";
            double media = 0;

            Console.Write("Informe a 1ª nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Informe a 2ª nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                mensagem = "Aprovado";
            }
            else if (media >= 5 && media < 7)
            {
                mensagem = "Recuperação";
            }
            else
            {
                mensagem = "Reprovado";
            }
            Console.WriteLine($"O Status do Aluno de Média: {media} é {mensagem}");

        }
    }
}
