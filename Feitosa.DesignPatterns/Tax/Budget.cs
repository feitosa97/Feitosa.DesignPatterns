using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class Budget
    {
        

        public BugdetState ActualState { get; set; }
        
        public double Value { get; internal set; }
        public IList<Item> Items { get; internal set; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
            ActualState = new OnApproval();
        }

        public void AddItem(Item item)
        { 
            Items.Add(item); 
        }    

        public void ApplyExtraDiscount()
        {
            ActualState.ApplyExtraDiscount(this);
        }

        public void Approve() { ActualState.Approve(this);}
        public void Disapprove() { ActualState.Disapprove(this); }
        public void Finish() { ActualState.Finish(this); }
    }
}
