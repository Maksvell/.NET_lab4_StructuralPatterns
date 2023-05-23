using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    public class Runner : IRunner
    {
        private readonly IDictCommands commands;

        public Runner(IDictCommands com)
        {
            commands = com;
        }

        public string Menu()
        {
            string res = "Enter the number:\n0. Exit\n";

            int i = 1;
            foreach (var name in Enum.GetValues(typeof(CommandsEnum)))
            {
                if (i == 13) res += "Queries:\n";
                res += $"{i}. {name} \n";
                i++;
            }
            return res;
        }
        public void Run()
        {
            commands.Load();
            while (true)
            {
                Console.WriteLine(Menu());
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if(num == 0) break;
                    else commands.Invoke(num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }
        }
}
}
