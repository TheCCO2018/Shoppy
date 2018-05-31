using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Tables
{
    public class LinkedHashEntry
    {
        private string key;
        private List<object> value;

        public List<object> Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private LinkedHashEntry next;

        public LinkedHashEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public LinkedHashEntry(string key, object value)
        {
            Value = new List<object>();
            this.Key = key;
            Value.Add(value);
            this.next = null;
        }

    }
}
