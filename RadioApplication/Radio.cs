using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    public class Radio : INotifyPropertyChanged
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel
        {
            get
            {
                if (_channel < 1 && _channel > 4)
                {
                    return _channel = 1;
                }
                return this._channel;
            }
            set
            {
                if (_on == true)
                {
                    if (value > 0 && value < 5)
                    {
                        _channel = value;
                        this.NotifyPropertyChanged(value);
                    }
                }
                else
                {
                    _channel = 1;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(int propertyName)
        {
            string results = propertyName.ToString();
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(results));
        }

        public string Play()
        {
            if (_on == false)
            {
                return "Radio is off";
            }
            else
            {
                return $"Playing channel {_channel}";
            }

        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }
    }
}
