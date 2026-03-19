using System;

namespace SistemaMedia
//É o mesmo nome do projeto/pasta
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        //Propriedades da classe

        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            //Construtor de classe
        }

        public double CalculoMedia()
        {
            return (Nota1 + Nota2) /2;
            //Método de cálculo da média
        }

        public void ExibirResultado()
        {
            double media = CalculoMedia();
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Media: {media}");

            if (media >= 6.0)
            {
                Console.WriteLine("Status: Aprovado");
            }
            else
            {
                Console.WriteLine("Status: Reprovado");
                //Método para exibir o resultado
            }
        }
    }

}