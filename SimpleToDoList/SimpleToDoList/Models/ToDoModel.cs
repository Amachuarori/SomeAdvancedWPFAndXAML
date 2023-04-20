using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.Models
{
    internal class ToDoModel : INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(PropertyName = "creationTime")]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _isDone; }
            set 
            { 
                if(_isDone == value)
                {
                    return;
                }
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get { return _text; }
            set
            {
                if(_text == value)
                {
                    return;
                }
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        
    }
}
