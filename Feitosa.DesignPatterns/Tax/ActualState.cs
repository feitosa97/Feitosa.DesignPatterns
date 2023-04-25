using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public interface BugdetState
    {
        void ApplyExtraDiscount(Budget budget);
        void Approve(Budget budget);
        void Disapprove(Budget budget);
        void Finish(Budget budget);
    }
    public class ActualState
    {
    }

    public class OnApproval : BugdetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            budget.Value -= budget.Value * 0.05;
        }

        public void Approve(Budget budget)
        {
            budget.ActualState = new Approved();
        }

        public void Disapprove(Budget budget)
        {
            budget.ActualState = new Disapproved();

        }

        public void Finish(Budget budget)
        {
            throw new Exception("On Approval budget can't be finished");
        }
    }
    public class Approved : BugdetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            budget.Value -= budget.Value * 0.02;

        }

        public void Approve(Budget budget)
        {
            throw new Exception("Budget already aprroved");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Budget already aprroved");
        }

        public void Finish(Budget budget)
        {
            budget.ActualState = new Finished();
        }
    }
    public class Disapproved : BugdetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            throw new Exception("Can't apply extra discount on disapproved budgets");
        }

        public void Approve(Budget budget)
        {
            throw new Exception("Budget already disaprroved");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Budget already disaprroved");
        }

        public void Finish(Budget budget)
        {
            budget.ActualState = new Finished();
        }
    }
    public class Finished : BugdetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            throw new Exception("Can't apply extra discount on finished budgets");

        }
        public void Approve(Budget budget)
        {
            throw new Exception("Budget already finished");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Budget already finished");
        }

        public void Finish(Budget budget)
        {
            throw new Exception("Budget already finished");
        }
    }
}
