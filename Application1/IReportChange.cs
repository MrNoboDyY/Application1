﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    interface IReportChange
    {
        bool HasChanged
        {
            get;
            set;
        }
    }
    event EventHandler Changed;
    
}
