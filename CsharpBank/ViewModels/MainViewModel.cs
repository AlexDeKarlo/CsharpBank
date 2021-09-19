using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CsharpBank.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        public ICommand LoginButton { get; set; }
        public ICommand RegistrationButton { get; set; }

        private string LoginTextBox;
        public string logintextbox
        {
            set
            {
                LoginTextBox = value;
                RaisePropertyChanged(nameof(LoginTextBox));
            }
            get
            {
                return LoginTextBox;
            }
        }


        private string RegisterTextBox;
        public string registertextbox
        {
            set
            {
                RegisterTextBox = value;
                RaisePropertyChanged(nameof(RegisterTextBox));
            }
            get
            {
                return RegisterTextBox;
            }
        }

        public MainViewModel()
        {
            LoginButton = new RelayCommand((e) =>
            {
                MessageBox.Show("Логин");

            });
            RegistrationButton = new RelayCommand((e) =>
            {
                MessageBox.Show("Регистрация");
            });
        }
    }
}
