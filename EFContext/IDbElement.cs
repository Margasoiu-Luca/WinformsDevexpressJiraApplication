using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Models
{
    public class IDbElement<T> where T : IDbElement<T>
    {
        int id { get; set; }
        public T getDbElement()
        {
            return (T)this;
        }
    }
}
