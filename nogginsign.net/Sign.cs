using nogginsign.net.Exceptions;
using System;
using System.Diagnostics.Contracts;
using System.IO.Ports;

namespace NogginSign.net
{
    public class Sign
    {
        private SerialPort _port;

        /// <summary>
        /// Are we connected via USB serial to a sign
        /// </summary>
        public bool Connected => _port != null;

        public void Connect()
        {
            string[] availablePorts;
            try
            {
                availablePorts = SerialPort.GetPortNames();
                _port = new SerialPort();
            }
            catch(PlatformNotSupportedException ex)
            {
                throw new NogginSignConnectionException("", ex);
            }
           
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

        public void Send(SignText command)
        {
            Contract.Requires(command != null);
            if(_port == null)
            {
                throw new NogginSignConnectionException("No sign is connected");
            }
            if (!_port.IsOpen)
            {
                _port.Open();
            }
            var commandText = command.ToString();
            _port.Write(commandText);

            //_port.Write($"_01Z00_02A0{command.Text}_04");
        }
    }
}
