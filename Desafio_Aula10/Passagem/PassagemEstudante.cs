using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemEstudante : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 2; }
        public override string TipoPassageiro { get => "Estudante"; }



        public Seguro seguro { get; set; }

        public PoltronasViewModel PoltronaSelecionada_;

        //public override string ToString()
        //{
        //    return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        //}

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro estudante");
        }

        public override double CalcularTotalPagamento(double valor) // pensar caso tiver seguro
        {
            double valorAssento = valor;
            // tem que chegar aqui a escolha da poltrona
            //if(PoltronaSelecionada_.Poltrona == "P1" ||
            //    PoltronaSelecionada_.Poltrona == "P2" ||
            //    PoltronaSelecionada_.Poltrona == "P3" ||
            //    PoltronaSelecionada_.Poltrona == "P4" ||
            //    PoltronaSelecionada_.Poltrona == "P5")
            //{
            //    valorAssento = valor - (valor * 0.15);
            //}

            
            
                ValorTotalCompra = valorAssento + (valorAssento * seguro.ValorSeguro);
                return ValorTotalCompra;
            
            // arrumar essa função
            // precisa ser pensado aqui caso seja poltrona entre 1 e 5
            // pensado aqui também que o valor que chega é um valor pré-fixado
        }
    }
}
