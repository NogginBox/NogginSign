using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NogginSign.net;

namespace NogginSign.ExampleWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Sign _sign;

        public MainWindow()
        {
            InitializeComponent();
            _sign = new Sign();
        }


        private void OnSend(object sender, RoutedEventArgs e)
        {
            if(!_sign.Connected)
            {
                _sign.Connect();
            }

            var text = String.IsNullOrWhiteSpace(SignText.Text)
                ? "Banana"
                : SignText.Text;
            var command = new SignText(text, priority: true);
            _sign.Send(command);
        }
    }
}
