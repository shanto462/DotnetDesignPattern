using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class Switch
    {
        private readonly ICommand _closedCommand;
        private readonly ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            this._closedCommand = closedCommand;
            this._openedCommand = openedCommand;
        }
        public void Close()
        {
            this._closedCommand.Execute();
        }
        public void Open()
        {
            this._openedCommand.Execute();
        }
    }
}
