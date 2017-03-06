using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm.Apolo.Core.Result
{
    public class SimpleItemDto<TId>
    {
        public SimpleItemDto()
        {

        }
        public SimpleItemDto(TId id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public TId Id { get; set; }
        public string Descripcion { get; set; }
    }
}
