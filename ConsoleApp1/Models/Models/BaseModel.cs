using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    internal class BaseModel<T> where T:BaseModel<T>
    {
        public int? id { get; set; }
        public T getDbElement()
        {
            return (T)this;
        }
    }
}
