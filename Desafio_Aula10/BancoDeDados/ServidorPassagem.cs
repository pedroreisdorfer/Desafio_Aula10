using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class ServidorPassagem
    {
        public void Salvar(TiposPassageiro tiposPassageiro, Origem_Destino origem_Destino)
        {
            Console.WriteLine($"Servidor AAA - Salvando pagamento: R$ {tiposPassageiro.ValorTotalCompra} ");
            Console.WriteLine($"Passagem de forma: "); // colocar aqui lógica da forma de passagem
            Console.WriteLine($"Tipo passageiro{tiposPassageiro.TipoPassageiro}");
            Console.WriteLine($"Origem: {origem_Destino.Origem}");
            Console.WriteLine($"Origem: {origem_Destino.Destino}");
        }
    }
}
