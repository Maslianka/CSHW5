using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHW
{
    interface IDeveloper
    {

        //Create interface IDeveloper with property Tool, methods Create() and Destroy()
        string Tool { get; set; }

        void Create();
        void Destroy();

    }
}
