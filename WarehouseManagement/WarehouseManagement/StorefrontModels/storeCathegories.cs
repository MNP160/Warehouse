﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseManagement.StorefrontModels
{
    public class storeCathegories
    {
        [Key]
        public int storeCathegoryId { get; set; }
        public string Name { get; set; }


        public ICollection<storeItems> items { get; set; }
    }
}
