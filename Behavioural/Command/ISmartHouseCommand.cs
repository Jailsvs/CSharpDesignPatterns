using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioural.Command
{
    public interface ISmartHouseCommand
    {
        void Execute();
        void Undo();
    }
}
