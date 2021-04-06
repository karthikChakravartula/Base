using System;
using System.Collections.Generic;
using System.Text;

namespace Interfce
{
    interface ILogic
    {
        int DoAdd(int a, int b);
        int DoSub(int a, int b);

    }

    interface ILogic2 :ILogic
    {
        int DoMul(int a, int b);
        int Dodiv(int a, int b);

    }
}
