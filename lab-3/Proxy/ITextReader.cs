﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Proxy
{
    public interface ITextReader
    {
        char[][] ReadFile(string path);
    }
}