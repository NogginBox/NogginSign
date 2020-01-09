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
        private readonly Sign _sign;

        public MainWindow()
        {
            InitializeComponent();

            //TextPosition.ItemsSource = 
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

            var p = ((ComboBoxItem)TextPosition.SelectedItem)?.Content;
            var position = p switch
            {
                "Middle Line" => Positions.MiddleLine,
                "Bottom Line" => Positions.BottomLine,
                "Left" => Positions.Left,
                "Top Line" => Positions.TopLine,
                "Right" => Positions.Right,
                "Fill" => Positions.Fill,
                _ => Positions.Fill
            };

            var m = ((ComboBoxItem)TextMode.SelectedItem)?.Content;
            var mode = m switch
            {
                "Rotate" => Modes.Rotate,
                "Hold" => Modes.Hold,
                "Flash" => Modes.Flash,
                "Roll Up" => Modes.RollUp,
                "Roll Down" => Modes.RollDown,
                "Roll Left" => Modes.RollLeft,
                "Roll Right" => Modes.RollRight,
                "Wipe Up" => Modes.WipeUp,
                "Wipe Down" => Modes.WipeDown,
                "Wipe Left" => Modes.WipeLeft,
                "Wipe Right" => Modes.WipeRight,
                "Scroll" => Modes.Scroll,
                "Auto Mode" => Modes.AutoMode,
                "Roll In" => Modes.RollIn,
                "Roll Out" => Modes.RollOut,
                "Wipe In" => Modes.WipeIn,
                "Wipe Out" => Modes.WipeOut,
                "Compressed Rotate" => Modes.CompressedRotate,
                "Explode" => Modes.Explode,
                "Clock" => Modes.Clock,
                _ => Modes.Flash
            };


            var command = new SignText(text, position: position, mode: mode, priority: true);
            _sign.Send(command);
        }
    }
}
