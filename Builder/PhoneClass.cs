using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PhoneClass
    {
        public string phonetype;
        public string OS;
        public int size;
        public int ram;

        public PhoneClass(string type, string os, int size, int ram) {
            this.phonetype = type;
            this.OS = os;
            this.size = size;
            this.ram = ram;
        }

    }
}
