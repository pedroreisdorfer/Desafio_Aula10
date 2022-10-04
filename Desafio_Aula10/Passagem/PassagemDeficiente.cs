using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemDeficiente : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 4; }
        public override string TipoPassageiro { get => "Deficiente"; }

        public Seguro seguro;

        public PoltronasViewModel PoltronaSelecionada_;

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro deficiente");
        }

        public override double CalcularTotalPagamento(double valor) // pensar caso tiver seguro
        {
            valor = 0.00;
            

            if (seguro.Id_Seguro == 1)
            {
                ValorTotalCompra = valor + (valor * seguro.ValorSeguro);
                return ValorTotalCompra;
            }

            if (seguro.Id_Seguro == 2)
            {
                ValorTotalCompra = valor;
                return ValorTotalCompra;
            }
            ValorTotalCompra = valor;
            return ValorTotalCompra;
            // arrumar essa função
            // precisa ser pensado aqui caso seja poltrona entre 1 e 5
            // pensado aqui também que o valor que chega é um valor pré-fixado
        }
    }
}
