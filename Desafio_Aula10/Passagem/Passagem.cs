using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Passagem
    {
        public string Origem { get; set; }
        public string Destino { get; set; }

        //public DB_ContextPoltronas DB_ContextPoltronas_;

        private readonly DB_ContextPoltronas DB_ContextPoltronas_;

        // acesso a poltrona que foi digita no Console, buscando no banco de dados

        public TiposPassageiro tiposPassageiro;
    }
}
