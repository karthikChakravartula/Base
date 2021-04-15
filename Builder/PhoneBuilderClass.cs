using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PhoneBuilderClass
    {
        public string phonetype;
        public string OS;
        public int size;
        public int ram;

        public PhoneBuilderClass setPhonetype(string type)
        {
            this.phonetype = type;
            return this;
        }
        public PhoneBuilderClass setPhoneOs(string Os)
        {
            this.OS = Os;
            return this;
        }
        public PhoneBuilderClass setPhonesize(int size)
        {
            this.size = size;
            return this;
        }
        public PhoneBuilderClass setPhoneram(int ram)
        {
            this.ram = ram;
            return this;
        }

        public PhoneClass getPhone()
        {
            return new PhoneClass(this.phonetype, this.OS, this.size, this.ram);
        }
    }
}
