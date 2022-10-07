using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskkk.Interfaces
{
    internal interface IAccount
    {
        bool PasswordChecker(string str);
        void ShowInfo();

    }
}
