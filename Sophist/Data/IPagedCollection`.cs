﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sophist.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPagedCollection<T> : IPagedCollection, IEnumerable<T>
    {
    }
}