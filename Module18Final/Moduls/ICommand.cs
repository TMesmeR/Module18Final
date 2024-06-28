using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Final.Moduls
{
    internal interface ICommand
    {
        Task ExecuteAsync();
    }
}
