using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public static class DB_ContextPoltronas
    {
        public static List<PoltronasViewModel> ListaPoltronas;

        static DB_ContextPoltronas()
        {
            ListaPoltronas = new List<PoltronasViewModel>();
            InicializaDB();

        }

        public static void InicializaDB()
        {           
            for(int i = 1; i < 31; i++)
            {
                var poltrona = new PoltronasViewModel($"P{i}");
                ListaPoltronas.Add(poltrona);
            }
        }
    }
}
