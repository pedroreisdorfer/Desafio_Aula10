using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Seguro
    {
        public int Id_Seguro { get; set; }

        public double ValorSeguro { get; }
        // CREIO QUE terá que ser feito com o seguro com é feito com tipo passagem

        public Seguro()
        {
            if(Id_Seguro == 1)
            {
                this.ValorSeguro = 0.03;
            }
            if(Id_Seguro == 2)
            {
                this.ValorSeguro = 0;
            }

            // mas aqui precisa ter validação caso seja digitado outro número
            
        }

        // if Id == 0, seguro é zero
        // if Id == 1, seguro é 3%
    }
}
