using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Contract
{
    public class ContractState
    {
        public Contract Contract { get; private set; }
        public ContractState(Contract contract)
        {
            Contract = contract;
        }
    }
}
