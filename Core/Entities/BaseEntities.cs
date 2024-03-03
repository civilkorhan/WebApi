﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntities<TId>
    {
        public TId Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; } // soru işareti illa oluşturmak zorunda olmadığını gösterir
        public DateTime? DeletedDate { get; set; }
    }
}