using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemEstudante : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 2; }
        public override string TipoPassageiro { get => "Estudante"; }

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro estudante");
        }

        public override double CalcularTotalPagamento(double valor) // pensar caso tiver seguro
        {
            return valor;
        }
    }
}
