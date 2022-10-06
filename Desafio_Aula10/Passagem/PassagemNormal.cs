using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemNormal : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 1; }
        public override string TipoPassageiro { get => "Normal"; }

        //public Seguro seguro;

        //public PassagemNormal()
        //{
            
        //}

        //public override string ToString()
        //{
        //    return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        //}

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro normal");
        }

        public override double CalcularTotalPagamento(double valor, Seguro seguro) // pensar caso tiver seguro
        {

            //if (seguro.Id_Seguro == 1){
            //    ValorTotalCompra = valor + (valor * seguro.ValorSeguro);
            //    return ValorTotalCompra;
            //}
            //if(seguro.Id_Seguro == 2)
            //{
            //    ValorTotalCompra = valor;
            //    return ValorTotalCompra;
            //}
            
            return valor + (valor * seguro.ValorSeguro);
            // arrumar essa função
            // precisa ser pensado aqui caso seja poltrona entre 1 e 5

        }
    }
}
