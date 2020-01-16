using NogginSign.Constants;

namespace NogginSign
{
    /// <summary>
    /// Container for data to be sent to a sign device.
    /// Packet objects are created by other classes and should not usually be instantiated directly.
    /// </summary>
    internal class Packet
    {
        public Packet(string contents)
        {
            _contents = contents;
        }

        private readonly string _contents;

        /// <summary>
        /// Sign Address (see protocol)
        /// </summary>
        public string Address = "00";

        /// <summary>
        /// Type code (see protocol)
        /// </summary>
        public string Type { get; set; } = "Z";

        public string ToCode()
        {
            return $"{PacketConstants.SOH}{Type}{Address}{PacketConstants.STX}{_contents}{PacketConstants.EOT}";
        }

    }
}