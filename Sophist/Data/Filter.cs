﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophist.Data
{
    public class Filter<T> : FilterBase<T>
         where T : class, new()
    {
    }
}
