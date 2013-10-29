﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophist.Data.Mapping
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class TimestampAttribute : Attribute
    {
        public Boolean AutoAddNow { get; set; }
        public Boolean AutoUpdateNow { get; set; }
    }
}
