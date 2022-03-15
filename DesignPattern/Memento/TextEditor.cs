using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class TextEditor
    {
        private string _text;

        public TextEditor(string text)
        {
            _text = text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public string Text => _text;

        public ITextEditorMemento SaveChange()
        {
            return new UndoRedoTextEditorMemento(_text);
        }

        public void Restore(ITextEditorMemento memento)
        {
            if (memento is UndoRedoTextEditorMemento)
                this._text = memento.GetText();
            else
                throw new InvalidOperationException("Invalid Memento!");
        }
    }
}
