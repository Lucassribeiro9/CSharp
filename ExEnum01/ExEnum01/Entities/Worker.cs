using ExEnum01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnum01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // ele é do tipo enum
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // associação de classes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // atributo do tipo lista, pois a relação é de 1.N, ou seja, é uma lista de contratos. Já instanciada, inclusive
        public Worker()
        {

        }
        // quando o atributo for do tipo List, não será atribuído no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) // adicionar contratos
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) // remover contratos
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) // acréscimo de valor
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) // loop que irá rodar até terminar a quantidade de contratos
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); // adiciona o valor se a condição for verdadeira
                }
            }
            return sum;
        }
    }

   
}
