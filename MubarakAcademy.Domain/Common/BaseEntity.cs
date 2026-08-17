using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Domain.Common
{
   public abstract class BaseEntity
    {
        public DateTime CretedAt {  get; set; }
        public DateTime UpdateAt {  get; set; }
    }
}
