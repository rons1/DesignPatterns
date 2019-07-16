using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        public List<TextMemento> Memento = new List<TextMemento>();
        public int index = 0;

        public void AddMemento(TextMemento memento)
        {
            if (index < this.Memento.Count)
            {
                this.Memento.RemoveRange(index, this.Memento.Count - index);
            }

            this.Memento.Add(memento);
            index++;
        }

        public TextMemento GetLast()
        {
            if (index > 1)
                index--;

            return this.Memento[index-1];
        }

        public TextMemento GetNext()
        {
            if (index < Memento.Count)
                index++;

            return this.Memento[index-1];
        }
    }
}
