﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sophist.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public interface IEntity<TKey> : IEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        new TKey Id { get; set; }
    }
}
