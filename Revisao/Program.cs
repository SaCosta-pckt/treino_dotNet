using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno [] alunos = new Aluno[5];
            string escolha = ReceberEscolha();
            var indiceAluno = 0;

            while (escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1":
                        Console.Write("Digite o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.Write("Digite a nota do aluno: ");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (string.IsNullOrEmpty(a.Nome))
                            {
                               Console.WriteLine($"Aluno: {a.Nome} \n Nota: {a.Nota}\n"); 
                            }
                                
                        }

                        break;
                    case "3":
                        //Calcular média

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                
                escolha = ReceberEscolha();

            }
        }

        private static string ReceberEscolha()
        {
            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair\n");

            string escolha = Console.ReadLine();
            Console.WriteLine(" ");
            return escolha;
        }
    }
}