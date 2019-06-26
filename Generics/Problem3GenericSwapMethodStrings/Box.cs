using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3GenericSwapMethodStrings
{
    public class Box<TItem>
    {
        private List<TItem> boxCollection;
        public Box()
        {
            this.boxCollection = new List<TItem>();
        }

        public void Add(TItem item)
        {
            this.boxCollection.Add(item);
        }


        public void Swap(int x, int y)
        {
            TItem tempValue = this.boxCollection[x];
            this.boxCollection[x] = this.boxCollection[y];
            this.boxCollection[y] = tempValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var text in boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName}: {text}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
