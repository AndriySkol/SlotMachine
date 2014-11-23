using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            SlotMachine machine = new SlotMachine();
            machine.add(form);
            CommandHandler handler = new CommandHandler();
            form.commandHandler = handler;
            handler.AddCommand(new PutMoneyCommand(machine));
            handler.AddCommand(new TakeMoneyCommand(machine));
            handler.AddCommand(new TryCommand(machine));
            handler.AddCommand(new GetMoneyBackCommand(machine));


            Application.Run(form);
        }
    }
}
