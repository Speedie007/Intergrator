﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
    }
}