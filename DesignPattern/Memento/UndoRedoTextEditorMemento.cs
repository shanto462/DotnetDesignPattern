using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class UndoRedoTextEditorMemento : ITextEditorMemento
    {
        private readonly string _text;
        private readonly DateTime _timeStamp;

        public UndoRedoTextEditorMemento(string text)
        {
            _text = text;
            _timeStamp = DateTime.Now;
        }

        public string GetText()
        {
            return _text;
        }

        public DateTime GetTimeStamp()
        {
            return _timeStamp;
        }

        public override string ToString()
        {
            return $"{_text} at {_timeStamp}";
        }
    }
}
