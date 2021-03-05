using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ClassDemoOfDiffDesignPatterns.Annotations;

namespace ClassDemoOfDiffDesignPatterns.pattern.observer
{
    class ObservableObject : INotifyPropertyChanged
    {
        private int _id;
        private String _text;

        public ObservableObject(int id, string text)
        {
            _id = id;
            _text = text;
        }

        public ObservableObject()
        {
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value == _id) return;
                _id = value;
                Notify();
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                Notify();
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Text)}: {Text}";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  // kald af Update
        }
    }
}
