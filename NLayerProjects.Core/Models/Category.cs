﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProjects.Core.Models
{
   internal class Category
    {

        public Category()
        {
            Products = new Collection<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<Product>  Products { get; set; }

    }
}
