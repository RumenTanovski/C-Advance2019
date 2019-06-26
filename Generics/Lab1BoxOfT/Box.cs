using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public List<T> Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public int Count
        {
            get { return this.data.Count; }

        }

        public Box()
        {
            data = new List<T>();
        }


        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            var rem = this.data[data.Count - 1];
            data.RemoveAt(Count - 1);
            return rem;
        }
    }
}
