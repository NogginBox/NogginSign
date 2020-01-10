namespace NogginSign.net
{
	public interface ISign
	{
		/// <summary>
		/// Is the sign currently connected
		/// </summary>
		bool Connected { get; }

		/// <summary>
		/// Connects to the sign and thows an exception if there was a problem with this.
		/// </summary>
		void Connect();

		/// <summary>
		/// Sends a command to the sign
		/// </summary>
		string Send(ISignCommand command);
	}
}
