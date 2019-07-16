using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            if (careTake.Memento != null)
            {
                var last = careTake.GetLast();
                if (last.savedText != null)
                    richText.Text = last.savedText;
            }
        }

        public void Redo(RichTextBox richText)
        {
            if (careTake.Memento != null)
            {
                var next = careTake.GetNext();
                if (next.savedText != null)
                    richText.Text = next.savedText;
            }
        }
    }
}
