using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace PresentationLayer
{
    public class DictCommands : IDictCommands
    {
        private readonly IClient client;
        public DictCommands(IClient c)
        {
            client = c;
        }
        public Dictionary<CommandsEnum, Action> Dict = new Dictionary<CommandsEnum, Action>();

        public void Load()
        {
            Dict[CommandsEnum.SetFilmFromat] = new Action(client.SetFilmFromat);
            Dict[CommandsEnum.SetSportFromat] = new Action(client.SetSportFromat);
            Dict[CommandsEnum.SetMusicFromat] = new Action(client.SetMusicFromat);
            Dict[CommandsEnum.SetCustomFormat] = new Action(client.SetCustomFormat);
            Dict[CommandsEnum.ChangeDisk] = new Action(client.ChangeDisk);
            Dict[CommandsEnum.GetParams] = new Action(client.GetParams);
        }

        public void Invoke(int num)
        {
            if (Enum.TryParse((num - 1).ToString(), out CommandsEnum command)) {
                if (Dict.ContainsKey(command))
                {
                    Dict[command]();
                }
                else Console.WriteLine("Wrong input");
            }
            else Console.WriteLine("Wrong input");
        }
    }
}
