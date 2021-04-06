using System;
using System.Collections.Generic;
using System.Text;

namespace Interfce
{
    class SomeLogic2 : ILogic
    {
        int ILogic.DoAdd(int a, int b)
        {
            return -1; ;
        }

        int ILogic.DoSub(int a, int b)
        {
            return -1;
        }
    }
}
