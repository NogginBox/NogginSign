using System;
using System.Linq;
using System.Windows;
using EnumsNET;
using NogginSign.Commands;
using NogginSign.Constants;

namespace NogginSign.ExampleWpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
    {
        private readonly ISign _sign;

        public MainWindow()
        {
            InitializeComponent();

			TextPosition.ItemsSource = Enums.GetValues<Position>().Select(p => new Item<Position>(p.AsString(EnumFormat.Description), p)).ToList();
			//TextPosition.DisplayMemberPath = "Name";

			TextMode.ItemsSource = Enums.GetValues<Mode>().Select(p => new Item<Mode>(p.AsString(EnumFormat.Description), p)).ToList();

			_sign = new Sign();// FakeSign();
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

            var position = (TextPosition.SelectedItem as Item<Position>)?.Value
				?? Position.Fill;


            var mode = (TextMode.SelectedItem as Item<Mode>)?.Value
				?? Mode.NormalAutoMode;


            var command = new TextCommand(text, position: position, mode: mode, priority: true);
            var signOutput = _sign.Send(command);
			Console.WriteLine($"Sign command: {signOutput}");
        }
    }
}
