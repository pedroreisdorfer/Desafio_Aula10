using System;
using System.Collections.Generic;

namespace Desafio_Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<TiposPassageiro> listaOpcoesDePassagem = new List<TiposPassageiro> { new PassagemNormal(), new PassagemEstudante(), new PassagemAposentado(), new PassagemDeficiente()};


            IServidorPassagem servidorPassagem = new IServidorPassagem();

            Console.Write("Escolha sua Origem: ");
            string origem = Console.ReadLine(); // validação contra número. Em um programa mais completo, colocar lista de opção de origem
            Console.Write("Escolha sua Destino: ");
            string destino = Console.ReadLine();
            Origem_Destino origem_Destino = new Origem_Destino(origem, destino); // PASSADO DENTRO DO OBJETO PASSAGEM COMO PARÂMETRO DE ENTRADA

            origem_Destino.Origem = origem;
            origem_Destino.Destino = destino;

            Console.WriteLine();

            Console.WriteLine("Valor da passagem: R$ 60,00"); // Pode ser mais complexo caso seja variado conforme origem/destino
          
            // Deseja continuar com a compra? Digite uma para continuar. 2 para cancelar passagem

            Console.WriteLine("PoltronaS disponíveis: P1 a P30"); 
          
            Console.WriteLine();

            Console.WriteLine("Poltronas de 1 a 5 com desconto de 15%");
            Console.WriteLine("Passagem Digital com desconto de 5%"); 

            Console.WriteLine();

            Console.Write("Que Poltrona você deseja? ");
            string poltronaSelecionada = Console.ReadLine(); // é preciso fazer validações. Várias. Na medida da escolha, realizar os cálculos

            //System.Collections.IList list = DB_ContextPoltronas.ListaPoltronas;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    string OpcaoPoltrona = (string)list[i];
            //    if (OpcaoPoltrona == poltronaSelecionada)
            //    {
            //        PoltronasViewModel poltrona = new PoltronasViewModel(poltronaSelecionada);
            //    }
                    
            //} // ver se roda essa função


            PoltronasViewModel poltrona = new PoltronasViewModel(poltronaSelecionada);
            poltrona.Poltrona = poltronaSelecionada;

            Console.WriteLine();

            Console.WriteLine("Digite 1 caso queira Seguro Passagem: *acréscimo de 3% ");
            Console.WriteLine("Digite 2 caso não queira Seguro Passagem");
            int Id_Seguro = int.Parse(Console.ReadLine());
            
            Seguro seguro_ = new Seguro();
            seguro_.Id_Seguro = Id_Seguro;

            //if (Id_Seguro == 1)
            //{
            //    seguro_.ValorSeguro = 0.03;
            //}
            //if (Id_Seguro == 2)
            //{
            //    seguro_.ValorSeguro = 0.00;
            //}

            // A escolha do seguro ou não deve cair lá na impressão da Passagem
            Console.WriteLine();

            TiposPassageiro tipoPassageiroSelecionado = EscolherMeioDePagamento(listaOpcoesDePassagem);
            double valorPassagem = 60.00;
            tipoPassageiroSelecionado.CalcularTotalPagamento(valorPassagem);

            //InformaValorPassagem(tipoPassageiroSelecionado);

            servidorPassagem.Salvar(tipoPassageiroSelecionado);

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

        private static TiposPassageiro EscolherMeioDePagamento(List<TiposPassageiro> listaOpcoesDePassagem)
        {
            bool EscolheuTipoPassageiro = false;
            TiposPassageiro tipoPassageiroSelecionado = null;
            do
            {
                try
                {
                    Console.WriteLine("Escolha o meio de Pagamento de sua Passagem:");
                    foreach (var tipoDisponivel in listaOpcoesDePassagem)
                    {
                        Console.WriteLine($"Digite {tipoDisponivel.Id_TipoPassageiro} para {tipoDisponivel.TipoPassageiro}");
                    }

                    string id_tipoPassageiro = Console.ReadLine();
                    //tipoPassageiroSelecionado = PagamentoFactory.ValidaIDPagamentoERetornaObjetoPagamento(ID_PAGAMENTO);
                    tipoPassageiroSelecionado = TipoPassageiroFactory.ValidadorTipoPassageiro(id_tipoPassageiro);
                    EscolheuTipoPassageiro = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Tente novamente!");
                }

            } while (EscolheuTipoPassageiro == false);
            return tipoPassageiroSelecionado;
        }


        //private static void InformaValorPassagem(TiposPassageiro tipoPassageiroSelecionado)
        //{
        //    bool ValorValido = false;
        //    do
        //    {
        //        try
        //        {
        //            double valorPassagem = 60.00;
        //            double valorTotalCompra = tipoPassageiroSelecionado.CalcularTotalPagamento(valorPassagem); // strategy
        //            //ValorValido = tipoPassageiroSelecionado.ValidaValorPagamento(valorTotalCompra.ToString());
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    } while (ValorValido == false);
        //}

    }
}

