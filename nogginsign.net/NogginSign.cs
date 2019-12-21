using nogginsign.net.Exceptions;
using System.IO.Ports;

namespace NogginSign.net
{
    public class NogginSign
    {
        private SerialPort _port;

        public void Connect()
        {
            var availablePorts = SerialPort.GetPortNames();
            _port = new SerialPort();

            if (availablePorts.Length == 0)
            {
                throw new NogginSignConnectionException("No COM Port devices found");
            }

            _port.PortName = availablePorts[0];
            _port.BaudRate = 38400;
            //port.DataBits = 5; // 5 - 8
            //port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
            //port.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
            _port.Parity = Parity.None;
        }

        public void Send(ISignCommand command)
        {
            _port.Write(command.ToString());
        }
    }
}
