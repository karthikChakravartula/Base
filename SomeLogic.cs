using System;
using Interfce;

namespace CoreLogic
{
    public class SomeLogic : ILogic, ILogic2
    {
        public int add(int a , int b)
        {
            return a + b;
        }

        public int DoAdd(int a, int b)
        {
            return add(a, b);
        }

        public int Dodiv(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int DoMul(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int DoSub(int a, int b)
        {
            return Sub(a, b);
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
