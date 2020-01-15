using System.Diagnostics.Contracts;

namespace NogginSign
{
	/// <summary>
	/// A simple implementation of ISign that will just let you know the command codes generated without a real connected sign.
	/// </summary>
	public class FakeSign : ISign
	{
		public bool Connected => true;

		public void Connect()
		{
		}

		public string Send(ISignCommand command)
		{
			Contract.Requires(command != null);
			var commandText = command.ToString();
			return commandText;
		}
	}
}
