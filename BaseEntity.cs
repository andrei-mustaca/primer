using System;
using System.Collections.Generic;
using System.Text;

namespace Kracks.Entities
{
    /// <summary>
    /// TODO: Коменты
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
       public Guid Id { get; protected set; }

       protected bool Equals(object obj)
       {
            //TODO: Сравнение по id
       }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //TODO: Переопределить оператора == и !=
    }
}
