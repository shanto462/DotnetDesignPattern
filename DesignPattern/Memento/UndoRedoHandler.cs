using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public class UndoRedoHandler : IMementoHandler
    {
        private readonly Stack<ITextEditorMemento> _undos = new Stack<ITextEditorMemento>();
        private readonly Stack<ITextEditorMemento> _redos = new Stack<ITextEditorMemento>();

        private readonly TextEditor _textEditor;

        public UndoRedoHandler(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Save(SaveType saveType = SaveType.UNDO)
        {
            if (saveType == SaveType.UNDO)
            {
                _undos.Push(_textEditor.SaveChange());
            }
            else
            {
                _redos.Push(_textEditor.SaveChange());
            }
        }

        public void Undo()
        {
            if (_undos.Count == 0)
                return;

            var top = _undos.Pop();
            _textEditor.Restore(top);

            Save(SaveType.REDO);
        }

        public void Redo()
        {
            if (_redos.Count == 0)
                return;

            var top = _redos.Pop();
            _textEditor.Restore(top);

            Save(SaveType.UNDO);
        }

        public void ShowHistory()
        {
            Console.WriteLine("List of Undos");
            foreach (var memento in _undos)
            {
                Console.WriteLine(memento);
            }

            Console.WriteLine("List of Redos");
            foreach (var memento in _redos)
            {
                Console.WriteLine(memento);
            }
        }
    }
}
