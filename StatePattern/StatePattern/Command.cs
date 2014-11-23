using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class Command
    {
        protected SlotMachine machine;
        public abstract string Name{get;}
        
        public Command(SlotMachine machineIn)
        {
            machine = machineIn;
        }
        public abstract void Execute(object args = null);

    }
    public class PutMoneyCommand : Command
    {
        public static string name;
        public override string Name
        { get { return name; } }
        static PutMoneyCommand()
        {
            name = "PutMoney";
        }
        public PutMoneyCommand(SlotMachine machineIn)
            : base(machineIn)
        {
        }
        public override void Execute(object args)
        {

            machine.PutMoney((int)args);
        }
    }
    public class TakeMoneyCommand : Command
    {
        public static string name;
        public override string Name
        { get { return name; } }
        static TakeMoneyCommand()
        {
            name = "TakeMoney";
        }
        public TakeMoneyCommand(SlotMachine machineIn)
            : base(machineIn)
        {
        }
        public override void Execute(object args)
        {

            machine.TakeMoney();
        }
    }
    public class GetMoneyBackCommand : Command
    {
        public static string name;
        public override string Name
        { get { return name; } }
        static GetMoneyBackCommand()
        {
            name = "GetMoneyBack";
        }
        public GetMoneyBackCommand(SlotMachine machineIn)
            : base(machineIn)
        {
        }
        public override void Execute(object args)
        {

            machine.GetMoney();
        }
    }
    public class TryCommand : Command
    {
        public static string name;
        public override string Name
        { get { return name; } }
        static TryCommand()
        {
            name = "MakeTrial";   
        }
        public TryCommand(SlotMachine machineIn)
            : base(machineIn)
        {
        }
        public override void Execute(object args)
        {

            machine.Try();
        }
    }
    public class CommandHandler
    {
        Dictionary<string, Command> commands = new Dictionary<string,Command>();
        public void AddCommand(Command command)
        {
            commands.Add(command.Name, command);
        }
        public void Execute(string commandText, object args = null)
        {
            Command command;
            if (commands.TryGetValue(commandText, out command))
            {
                command.Execute(args);
            }

        }
    }
}