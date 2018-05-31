using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Trees
{
    public class HeapNode
    {
        public Product Value { get; set; }
        public HeapNode(Product value)
        {
            this.Value = value;
        }
    }
}
