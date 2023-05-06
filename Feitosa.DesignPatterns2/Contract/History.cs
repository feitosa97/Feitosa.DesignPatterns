using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Contract
{
    public class History
    {
        private IList<ContractState> States = new List<ContractState>();

        public void Add(ContractState state)
        {
            States.Add(state);
        }

        public ContractState Get(int index) 
        { 
            return States[index];
        }
    }
}
