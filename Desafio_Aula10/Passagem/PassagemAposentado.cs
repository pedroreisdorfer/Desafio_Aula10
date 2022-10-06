using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemAposentado : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 3; }
        public override string TipoPassageiro { get => "Aposentado"; }

        public Seguro seguro;

        public PoltronasViewModel PoltronaSelecionada_;

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro aposentado");
        }

        public override double CalcularTotalPagamento(double valor, Seguro seguro) // pensar caso tiver seguro
        {
            double valorAssento = valor;
            //// tem que chegar aqui a escolha da poltrona
            //if (PoltronaSelecionada_.Poltrona == "P1" ||
            //    PoltronaSelecionada_.Poltrona == "P2" ||
            //    PoltronaSelecionada_.Poltrona == "P3" ||
            //    PoltronaSelecionada_.Poltrona == "P4" ||
            //    PoltronaSelecionada_.Poltrona == "P5")
            //{
            //    valorAssento = valor - (valor * 0,15);
            //}

            if (seguro.Id_Seguro == 1)
            {
                ValorTotalCompra = valorAssento + (valorAssento * seguro.ValorSeguro);
                return ValorTotalCompra;
            }

            if (seguro.Id_Seguro == 2)
            {
                ValorTotalCompra = valorAssento;
                return ValorTotalCompra;
            }
            ValorTotalCompra = valorAssento;
            return ValorTotalCompra;
            // arrumar essa função
            // precisa ser pensado aqui caso seja poltrona entre 1 e 5
            // pensado aqui também que o valor que chega é um valor pré-fixado
        }
    }
}
