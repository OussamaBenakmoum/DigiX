﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2
{
    interface IException
    {
        Canvas panel { get; set; }
        void Gerer();
        
    }
}
