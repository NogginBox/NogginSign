namespace NogginSign.Constants
{
    /// <summary>
    /// Device constants are used during instantiation of interface classes (such as
    /// :class:`alphasign.interfaces.local.USB`) to describe particular sign devices.
    /// </summary>
    /// <example>
    /// Connect to a BetaBrite Prism sign using USB::
    /// sign = alphasign.USB(alphasign.devices.USB_BETABRITE_PRISM)
    /// sign.connect()
    /// </example>
    public class Devices
    {
        public readonly (int, int) USB_BETABRITE_PRISM = (0x8765, 0x1234);
    }
}