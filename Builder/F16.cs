using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class F16 : AircraftBuilder
    {
        public override void buidcockpit()        
        { 

        }
        public override void buildcontroller() { 
        }

        public override void buildengine()
        {
            throw new NotImplementedException();
        }

        public override void buildbathroom()
        {
            throw new NotImplementedException();
        }
    }
}
