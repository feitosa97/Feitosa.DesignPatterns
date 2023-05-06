using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Contract
{
    public class Contract
    {
        public DateTime Date { get; private set; }
        public string CustomerName { get; private set; }
        public ContractType Type { get; private set; }
        public Contract(DateTime date, string name, ContractType type) 
        {
            Date = date;
            CustomerName = name;
            Type = type;
        }

        public void Next() 
        {
            if (Type == ContractType.New) Type = ContractType.InProgress;
            else if (Type == ContractType.InProgress) Type = ContractType.Paid;
            else if (Type == ContractType.Paid) Type = ContractType.Done;
        }

        public ContractState Save()
        {
            return new ContractState(new Contract(Date, CustomerName, Type));
        }
    }
}