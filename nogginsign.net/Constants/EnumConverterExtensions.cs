using System;

namespace NogginSign.net.Constants
{
	internal static class EnumConverterExtensions
    {
        internal static string ToCode(this Position position)
        {
            return position switch
            {
                Position.MiddleLine => "\x20",
                Position.TopLine    => "\x22",
                Position.BottomLine => "\x26",
                Position.Fill       => "\x30",
                Position.Left       => "\x31",
                Position.Right      => "\x32",
                _ => throw new ArgumentException("Not a valid position")
            };
        }

		internal static string ToCode(this Mode mode)
		{
			return mode switch
			{
				// Normal display modes
				Mode.NormalRotate => "a",
				Mode.NormalHold => "b",
				Mode.NormalFlash => "c",
				Mode.NormalRollUp => "e",
				Mode.NormalRollDown => "f",
				Mode.NormalRollLeft => "g",
				Mode.NormalRollRight => "h",
				Mode.NormalWipeUp => "i",
				Mode.NormalWipeDown => "j",
				Mode.NormalWipeLeft => "k",
				Mode.NormalWipeRight => "l",
				Mode.NormalScroll => "m",
				Mode.NormalAutoMode => "o",
				Mode.NormalRollIn => "p",
				Mode.NormalRollOut => "q",
				Mode.NormalWipeIn => "r",
				Mode.NormalWipeOut => "s",
				Mode.NormalCompressedRotate => "t",
				Mode.NormalExplode => "u",
				Mode.NormalClock => "v",

				// Special modes
				Mode.SpecialTwinkle => "n0",
				Mode.SpecialSparkle => "n1",
				Mode.SpecialSnow => "n2",
				Mode.SpecialInterlock => "n3",
				Mode.SpecialSwitch => "n4",
				Mode.SpecialSlide => "n5",
				Mode.SpecialSpray => "n6",
				Mode.SpecialStarburst => "n7",
				Mode.SpecialWelcome => "n8",
				Mode.SpecialSlotMachine => "n9",
				Mode.SpecialNewsFlash => "nA",
				Mode.SpecialTrumpetAnimation => "nB",
				Mode.SpecialCycleColors => "nC",

				// Special graphics
				Mode.GraphicThankYou => "nS",
				Mode.GraphicNoSmoking => "nU",
				Mode.GraphicDontDrinkDrive => "nV",
				Mode.GraphicRunningAnimal => "nW",
				Mode.GraphicFishAnimation => "nW",
				Mode.GraphicFireworks => "nX",
				Mode.GraphicTurboCar => "nY",
				Mode.GraphicBalloonAnimation => "nY",
				Mode.GraphicCherryBomb => "nZ",
				_ => throw new ArgumentException("Not a valid Mode")
			};
		}
	}
}
