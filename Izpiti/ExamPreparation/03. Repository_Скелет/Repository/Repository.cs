using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;
        
        public Dictionary<int, Person> Data { get; set; }

        public int Count
        {
            get { return data.Count; }
        }

        public Repository()
        {
            data = new Dictionary<int, Person>();
        }

        public void Add(Person person)
        {
            if (data.Count == 0)
            {
                data.Add(0, person);
            }
            else
            {
                data.Add((data.Count + 1), person);
            }
        }

        public Person Get(int id)
        {
            return data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            bool result = true;
            if (data.ContainsKey(id))
            {
                data[id] = newPerson;
            }
            else result = false;
            return result;
        }

        public bool Delete(int id)
        {
            bool result = true;
            if (data.ContainsKey(id))
            {
                data.Remove(id);
            }
            else result = false;
            return result;
        }
    }
}
