using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    public abstract class State
    {
        protected SlotMachine machine;
        public State(SlotMachine machineIn)
        {
            machine = machineIn;
        }

        public abstract void PutMoney(int amount);
        public abstract void GetMoneyBack();
        public abstract void MakeTrial();
        public virtual void TakeMoney()
        {
            machine.Text = "There is nothing in the Money box at the moment";
        }
    }
    public class NoMoney : State
    {

        public NoMoney(SlotMachine machineIn) :
            base(machineIn)
        {
        }

        public override void PutMoney(int amount)
        {
            machine.MoneyPut = amount;
            machine.Text = "Now you can make a try";
            machine.State = new MoneyPut(machine);

        }

        public override void GetMoneyBack()
        {
            machine.Text = "You have not put any money yet";

        }

        public override void MakeTrial()
        {
            machine.Text = "You have not put any money yet";

        }
    }
    public class MoneyPut : State
    {
        public MoneyPut(SlotMachine machineIn) :
            base(machineIn)
        {
        }
        public override void PutMoney(int amount)
        {
            machine.Text = "You have already put some money";
        }

        public override void GetMoneyBack()
        {
            machine.GetBox = machine.MoneyPut;
            machine.MoneyPut = 0;
            machine.Text = "Please take your money";
            machine.State = new MoneyTake(machine);
        }

        public override void MakeTrial()
        {
            Random rnd = new Random();
            machine.X1 = rnd.Next(1, 3);
            machine.X2 = rnd.Next(1, 3);
            machine.X3 = rnd.Next(1, 3);

            if (machine.X1 == machine.X2 && machine.X2 == machine.X3)
            {
                machine.Text = "You won";
                machine.GetBox = machine.MoneyPut * 2;
                machine.MoneyPut = 0;
                machine.State = new MoneyTake(machine);
            }
            else
            {
                machine.Text = "You lost, sorry";
                machine.MoneyPut = 0;
                machine.State = new NoMoney(machine);

            }

        }
        public class MoneyTake : State
        {
            public MoneyTake(SlotMachine machineIn)
                : base(machineIn)
            {
            }

            public override void PutMoney(int amount)
            {
                machine.Text = "Please take your money first";
            }

            public override void GetMoneyBack()
            {
                machine.Text = "Please take your money first";
            }

            public override void MakeTrial()
            {
                machine.Text = "Please take your money first";
            }
            public override void TakeMoney()
            {
                machine.GetBox = 0;
                machine.Text = "Put some money to start";
                machine.State = new NoMoney(machine);

            }

        }
    }
}
