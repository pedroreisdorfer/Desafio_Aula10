using System;

namespace Desafio_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha sua Origem: ");
            string origem = Console.ReadLine(); // validação contra número. Em um programa mais completo, colocar lista de opção de origem
            Console.Write("Escolha sua Destino: ");
            string destino = Console.ReadLine();
            Origem_Destino origem_Destino = new Origem_Destino(origem, destino); // PASSADO DENTRO DO OBJETO PASSAGEM COMO PARÂMETRO DE ENTRADA
            //De: __________ OK
            //Para:_________ OK
            // O que for digitado aqui irá para formação passagem para ser impressa no final

            Console.WriteLine();

            Console.WriteLine("Valor da passagem: R$ 60,00"); // ou colocar em uma variável ou tal valor já estar dentro de uma variável. Pode ser mais complexo caso seja variado conforme origem/destino

            // Deseja continuar com a compra? Digite uma para continuar. 2 para cancelar passagem

            Console.WriteLine("PoltronaS disponíveis: P1 a P30"); // Não imprimir toda a lista, pois é muito grande
          
            Console.WriteLine();

            Console.WriteLine("Poltronas de 1 a 5 com desconto de 15%");
            Console.WriteLine("Passagem Digital com desconto de 5%");

            Console.WriteLine();

            Console.Write("Que Poltrona você deseja? ");
            string poltronaSelecionada = Console.ReadLine(); // é preciso fazer validações. Várias. Na medida da escolha, realizar os cálculos

            System.Collections.IList list = DB_ContextPoltronas.ListaPoltronas;
            for (int i = 0; i < list.Count; i++)
            {
                string OpcaoPoltrona = (string)list[i];
                if (OpcaoPoltrona == poltronaSelecionada)
                {
                    PoltronasViewModel poltrona = new PoltronasViewModel(poltronaSelecionada);
                }
                    
            } // ver se roda essa função


             // colocar nos parâmetros para gravar na passagem

            Console.WriteLine();

            

            Console.WriteLine();

            Console.WriteLine("Deseja Passagem com Seguro? *acréscimo de 3% ");
            // valor atual da passagem pode até ser impresso logo depois com cálculo já feito, mas seria uma perfumaria
            Console.WriteLine();




            //Lista de opções de poltronas
            // Lista de passagens de 1 a 30

            // Console: Poltronas de 1 a 5 com desconto de 15%
            // Console: Passagem Digital com desconto de 5%

            //Console: "Escolha sua Poltrona"
            // Validação de poltrona existente
            // Caso não exista => Console: Poltrona Inválida (se tiver opção de comprar mais que uma poltrona, "poltrona já selecionada" ou "Poltrona Inexistente
            // Console: "Escolha sua Poltrona"
            // Caso Poltrona válida, salvar selecção da Poltrona no objeto Passagem
            // Imprimir valor da passagem: 60,00 

            //Console: "Deseja Passagem com Seguro?"
            // Se sim, acréscimo de 3%. Se não, mantém valor da passagem

            //Console: Digite 1 para Passagem Normal (Caso for escolhido passagem entre as poltronas de 1 a 5, colocar desconto de 15%; Caso contrário, mantém valor passagem)
            // Digite 2 para Passagem Estudante (Caso for escolhido passagem entre as poltronas de 1 a 5, não é acrescido desconto de 10% por ser estudante, mas mantém valor da passagem com desconto de 15%. Caso contrário, desconto de 10% em cima do valor normal)
            // Digite 3 para Passagem Aposentado (Caso for escolhido passagem entre as poltronas de 1 a 5, não é acrescido desconto de 10% por ser aposentado, mas mantém valor da passagem com desconto de 15%. Caso contrário, desconto de 10% em cima do valor normal)
            // Digite 4 para Passagem Deficiente (Valor da passagem se torna gratuita)

            // salvar em uma lista local a formação do bilhete


        }
    }
}
