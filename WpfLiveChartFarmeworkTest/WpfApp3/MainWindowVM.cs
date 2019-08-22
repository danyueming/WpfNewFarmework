using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp3
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        private UserControl _content;
        public UserControl Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }


        private bool _isMenuOpen;
        public bool IsMenuOpen
        {
            get { return _isMenuOpen; }
            set
            {
                _isMenuOpen = value;
                OnPropertyChanged("IsMenuOpen");
            }
        }

        private string _criteria;

        private IEnumerable<SampleGroupVm> _samples;
        public IEnumerable<SampleGroupVm> Samples
        {
            get { return _samples; }
            set
            {
                _samples = value;
                OnPropertyChanged("Samples");
            }
        }
        private readonly IEnumerable<SampleGroupVm> _dataSource;

        public MainWindowVM()
        {
            _dataSource = new[]
            {
                new SampleGroupVm
                {
                    Name = "Customizing",
                    Items = new[]
                    {
                         new SampleVm("Series", typeof(MyTestControl)),
                          new SampleVm("Energy", typeof(MySecond))

                    }
                }
            };

            _samples = _dataSource;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class IsNulLConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
