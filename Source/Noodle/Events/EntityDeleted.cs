﻿namespace Noodle.Events
{
    /// <summary>
    /// A container for passing entities that have been deleted. This is not used for entities that are deleted logicaly via a bit column.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityDeleted<T>
    {
        private readonly T _entity;

        public EntityDeleted(T entity)
        {
            _entity = entity;
        }

        public T Entity { get { return _entity; } }
    }
}
