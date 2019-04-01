using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Events
{
    public partial class EntityDeletedEvent<T> where T : BaseEntity
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="entity">Entity</param>
        public EntityDeletedEvent(T entity)
        {
            this.Entity = entity;
        }

        /// <summary>
        /// Entity
        /// </summary>
        public T Entity { get; }
    }
}
