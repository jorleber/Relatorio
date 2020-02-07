using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatoriosJorge.Models.Cliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public string DataNascimento { get; set; }



        public static List<Cliente> Exemplos()
        {
            Random randNum = new Random();
            List<Cliente> list = new List<Cliente>();

            for (int i = 0; i < 21; i++)
            {
                list.Add(new Cliente()
                {
                    Id = i,
                    Nome = "Cliente" + i,
                    Saldo = Math.Round((randNum.NextDouble() * 1000), 2),
                    DataNascimento = randNum.Next(1, 28).ToString() + "/" + randNum.Next(1, 12).ToString() + "/" + randNum.Next(1990, 2020).ToString()
                });
            }
            return list;
        }
    }
}
