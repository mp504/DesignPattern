using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        public string Text { get; }

        public Memento(string text)
        {
            Text = text;
        }
    }

    public class TextEditor
    {
        private string _text = string.Empty;

        public void Type(string text)
        {
            _text += text;
        }

        public string GetText()
        {
            return _text;
        }

        public Memento Save()
        {
            return new Memento(_text);
        }

        public void Restore(Memento memento)
        {
            _text = memento.Text;
        }
    }


    

    public class Caretaker
    {
        private readonly List<Memento> _mementos = new List<Memento>();
        private readonly TextEditor _textEditor;

        public Caretaker(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Save()
        {
            _mementos.Add(_textEditor.Save());
        }

        public void Undo()
        {
            if (_mementos.Count > 0)
            {
                Memento lastMemento = _mementos[_mementos.Count - 1];
                _mementos.RemoveAt(_mementos.Count - 1);
                _textEditor.Restore(lastMemento);
            }
        }

        public void ShowHistory()
        {
            for (int i = 0; i < _mementos.Count; i++)
            {
                Console.WriteLine($"State {i + 1}: {_mementos[i].Text}");
            }
        }
    }



}
