using System.ComponentModel;

namespace NogginSign.Constants
{
	/// <summary>
	/// Display positions
	/// </summary>
	public enum Position
	{
		[Description("Middle line")]
		MiddleLine,

		[Description("Top line")]
		TopLine,

		[Description("Bottom line")]
		BottomLine,

		[Description("Fill")]
		Fill,

		[Description("Left")]
		Left,

		[Description("Right")]
		Right     
	}
}
