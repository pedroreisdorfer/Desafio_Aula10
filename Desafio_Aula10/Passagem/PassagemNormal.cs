using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemNormal : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 1; }
        public override string TipoPassageiro { get => "Normal"; }

        public Seguro seguro;

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro normal");
        }

        public override double CalcularTotalPagamento(double valor) // pensar caso tiver seguro
        {
            if (seguro.Id_Seguro == 1){
                return valor + (valor * seguro.ValorSeguro);
            }
            if(seguro.Id_Seguro == 2)
            {
                return valor;
            }
            return valor; 
            // arrumar essa função

        }
    }
}
