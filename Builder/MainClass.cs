using System;

namespace Builder
{
    public class MainClass
    {
        PhoneClass pp = new PhoneBuilderClass().setPhoneOs("windows").setPhonesize(10).getPhone();
    }
}
