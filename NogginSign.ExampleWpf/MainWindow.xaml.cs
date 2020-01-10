using NogginSign.net;
using NogginSign.net.Constants;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

            //TextPosition.ItemsSource = 
            _sign = new FakeSign();
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

            var p = ((ComboBoxItem)TextPosition.SelectedItem)?.Content;
            var position = p switch
            {
                "Middle Line" => Position.MiddleLine,
                "Bottom Line" => Position.BottomLine,
                "Left" => Position.Left,
                "Top Line" => Position.TopLine,
                "Right" => Position.Right,
                "Fill" => Position.Fill,
                _ => Position.Fill
            };

            var m = ((ComboBoxItem)TextMode.SelectedItem)?.Content;
            var mode = m switch
            {
                "Rotate" => Mode.NormalRotate,
                "Hold" => Mode.NormalHold,
                "Flash" => Mode.NormalFlash,
                "Roll Up" => Mode.NormalRollUp,
                "Roll Down" => Mode.NormalRollDown,
                "Roll Left" => Mode.NormalRollLeft,
                "Roll Right" => Mode.NormalRollRight,
                "Wipe Up" => Mode.NormalWipeUp,
                "Wipe Down" => Mode.NormalWipeDown,
                "Wipe Left" => Mode.NormalWipeLeft,
                "Wipe Right" => Mode.NormalWipeRight,
                "Scroll" => Mode.NormalScroll,
                "Auto Mode" => Mode.NormalAutoMode,
                "Roll In" => Mode.NormalRollIn,
                "Roll Out" => Mode.NormalRollOut,
                "Wipe In" => Mode.NormalWipeIn,
                "Wipe Out" => Mode.NormalWipeOut,
                "Compressed Rotate" => Mode.NormalCompressedRotate,
                "Explode" => Mode.NormalExplode,
                "Clock" => Mode.NormalClock,
                _ => Mode.NormalAutoMode
			};


            var command = new SignText(text, position: position, mode: mode, priority: true);
            var signOutput = _sign.Send(command);
			Console.WriteLine($"Sign command: {signOutput}");
        }
    }
}
