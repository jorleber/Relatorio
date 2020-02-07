using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosJorge.Models.ContaPagar
{
    public class ContaPagar
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public double Multa { get; set; }
        public double Juros { get; set; }
        public int Status { get; set; }


        public static IQueryable<ContaPagar> Exemplos()
        {
            Random randNum = new Random();
            List<ContaPagar> list = new List<ContaPagar>();
            DateTime auxData;
            for (int i = 0; i < 100; i++)
            {
                auxData = GerarData();
                list.Add(new ContaPagar()
                {
                    Codigo = randNum.Next(10000, 99999),
                    Descricao = "Pagamento :" + i,
                    DataLancamento = auxData,
                    DataVencimento = auxData.AddDays(10),
                    Valor = Math.Round((randNum.NextDouble() * 100), 2),
                    Multa = Math.Round((randNum.NextDouble() * 10), 2),
                    Juros = Math.Round((randNum.NextDouble() * 10), 2),
                    Status = randNum.Next(0, 3)
                });
            }
            return list.AsQueryable();
        }

        public static DateTime GerarData()
        {
            Random rnd = new Random();
            int ano = rnd.Next(2019, 2021);
            int mes = rnd.Next(1, 12);
            int dia = DateTime.DaysInMonth(ano, mes);
            int Dia = rnd.Next(1, dia);
            DateTime data = new DateTime(ano, mes, Dia);
            return data;
        }
    }
}
