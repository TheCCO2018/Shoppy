using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Tables
{
    public class HashMapChain
    {
        int TABLE_SIZE;
        LinkedHashEntry[] table;


        public HashMapChain(int MapSize)
        {
            TABLE_SIZE = MapSize;
            table = new LinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }

        // Refactor for our project
        public void AddItem(string key, object value)
        {
            int hash = (Hash(key) % TABLE_SIZE);
            if (table[hash] == null)
                table[hash] = new LinkedHashEntry(key, value);
            else {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Key != key)
                    entry = entry.Next;
                if (entry.Key == key)
                    entry.Value.Add(value);
                else
                    entry.Next = new LinkedHashEntry(key, value);
            }
        }
        public List<object> GetItem(string key)
        {
            int hash = (Hash(key) % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Key != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return entry.Value;
            }
        }
        public void ClearTable()
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = null;
            }
        }
        public int Hash(string key)
        {
            int sumOfLetters = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sumOfLetters += key[i];
            }
            return sumOfLetters;
        }
        
    }
}
