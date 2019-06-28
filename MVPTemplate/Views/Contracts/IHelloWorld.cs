using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTemplate.Views.Contracts
{
    public interface IHelloWorld
    {
        event EventHandler LoadText;
        event EventHandler ChangeText;
        void SetText(string data);
    }
}
