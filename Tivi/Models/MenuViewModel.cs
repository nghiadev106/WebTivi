using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MayTinh.Data;

namespace MayTinh.Models
{
    public class MenuViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> ListProductHot { get; set; }
        public List<Product> ListProductNew { get; set; }
    }
}
