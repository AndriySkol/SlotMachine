using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form, Observer
    {

        public CommandHandler commandHandler { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            commandHandler = new CommandHandler();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                commandHandler.Execute(PutMoneyCommand.name, x);
            }
            catch(Exception)
            {
                LabelInfo.Text = "Wrong money you put";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandHandler.Execute(TryCommand.name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commandHandler.Execute(GetMoneyBackCommand.name);
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            commandHandler.Execute(TakeMoneyCommand.name);
        }

        public void Update(Observable observable)
        {
            SlotMachine machine = observable as SlotMachine;
            LabelInfo.Text = machine.Text;
            labelMoneyAmount.Text = Convert.ToString(machine.MoneyPut);
            labelWinBoxVal.Text = Convert.ToString(machine.GetBox);
            label1.Text = Convert.ToString(machine.X1);
            label2.Text = Convert.ToString(machine.X2);
            label3.Text = Convert.ToString(machine.X3);

            Update();

        }
        
       
    }
}
