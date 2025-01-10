using System;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        //Gerar um numero aleatorio entre 1 e 20
        Random random = new Random();
        int numeroSorteado = random.Next(1, 21);

        int tentativas = 5;
        int palpite;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao jogo de adivinhar número!\n");
        Thread.Sleep(2000);
        Console.WriteLine("Eu sorteei um número entre 1 e 20.\n");
        Thread.Sleep(2000);
        Console.WriteLine("Você tem 5 tentativas para acertar. BOA SORTE!!!");
        Console.WriteLine("--------------------------------------------------");
        Thread.Sleep(2000);

        //Loop para as tentativas
        for (int i = 1; i <= tentativas; i++)
        {
            Console.WriteLine($"\nTentativa {i} de {tentativas}:");
            Console.WriteLine("Digite seu palpite: ");

            //Ler a entrada do usuario
            string entrada = Console.ReadLine();

            //Verificar se a entrada é um numero valido
            if (!int.TryParse( entrada, out palpite)) 
            {
                Console.WriteLine("Por favor, digite um numero válido.");
                i--; //Se a entrada não for valida, não consome tentativa
                continue;
            }

            //Verificar se o palpite esta correto
            if (palpite == numeroSorteado)
            {
                Console.WriteLine($"Parabéns! Você acertou! O numero sorteado é {numeroSorteado}");
                acertou = true;
                break;
            }
            else if (palpite < numeroSorteado)
            {
                Console.WriteLine("O numero sorteado é maior.");
            }
            else
            {
                Console.WriteLine("O numero sorteado é menor.");
            }
        }

        //Verificar se o jogador acertou o número
        if (!acertou)
        {
            Console.WriteLine($"\nVocê não acertou o número nas 5 tentativas.. O Numero sorteado era {numeroSorteado}");
        }

        Console.WriteLine("FIM DO JOGO! PRESSIONE QUALQUER TECLA PARA SAIR.");
        Console.ReadKey();
    }
}