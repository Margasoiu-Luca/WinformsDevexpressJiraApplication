using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class BaseModel<T> where T:BaseModel<T>
    {
        [Display(AutoGenerateField = false, Description = "Id Not Generated")]
        public int? id { get; set; }
        public T getDbElement()
        {
            return (T)this;
        }
        public BaseModel<T> getGeneric()
        {
            return (BaseModel < T > )this;
        }
    }
}
