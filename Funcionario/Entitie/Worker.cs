﻿using Funcionario.Entities.Enums;
using System.Collections.Generic;
namespace Funcionario.Entitie
{
     class Worker
    {
        public string  Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        
        public Worker(string name, WorkerLevel level, double basesalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;

        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalVelue();
                }
               
            }
            return sum;
        }


    }
}
