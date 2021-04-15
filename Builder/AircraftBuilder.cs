using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
     abstract class AircraftBuilder
    {
        public abstract void buidcockpit();
        public abstract void buildcontroller();
        public abstract void buildengine();
        public abstract void buildbathroom();
    }
}
