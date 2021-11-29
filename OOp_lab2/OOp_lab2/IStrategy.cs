using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_lab2
{
    interface IStrategy
    {
        List<Archive> Algorithm(Archive work, string path);
    }
}