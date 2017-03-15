using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm.Apolo.Dom.Entities
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        protected Entity()
        {
        }
        public virtual TKey Id { get; set; }

    }
}
