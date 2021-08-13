using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CsharpBank.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        public ICommand ButtonPressedCommand { get; set; }
        public MainViewModel()
        {
            ButtonPressedCommand = new RelayCommand((e) =>
            {
                MessageBox.Show("12345");
            });
        }
    }
}
