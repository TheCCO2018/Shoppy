using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Tables
{
    public class HashEntry
    {
        private string key;

        private object value;

        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        public HashEntry(string key, object value)
        {
            this.key = key;
            this.value = value;
        }


    }
}
