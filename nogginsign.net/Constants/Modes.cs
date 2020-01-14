using System.ComponentModel;

namespace NogginSign.net.Constants
{
    public enum Mode
    {
		// Normal display modes
		[Description("Rotate")]
		NormalRotate,

		[Description("Hold")]
		NormalHold,

		[Description("Flash")]
		NormalFlash,

		[Description("Roll up")]
		NormalRollUp,

		[Description("Roll down")]
		NormalRollDown,

		[Description("Roll left")]
		NormalRollLeft,

		[Description("Roll right")]
		NormalRollRight,

		[Description("Wipe up")]
		NormalWipeUp,

		[Description("Wipe down")]
		NormalWipeDown,

		[Description("Wipe left")]
		NormalWipeLeft,

		[Description("Wipe right")]
		NormalWipeRight,

		[Description("Scroll")]
		NormalScroll,

		[Description("Auto")]
		NormalAutoMode,

		[Description("Roll in")]
		NormalRollIn,

		[Description("Roll out")]
		NormalRollOut,

		[Description("Wipe in")]
		NormalWipeIn,

		[Description("Wipe out")]
		NormalWipeOut,

		[Description("Compressed rotate")]
		NormalCompressedRotate,

		[Description("Explode")]
		NormalExplode,

		[Description("Clock")]
		NormalClock,

		// Special modes

		[Description("Special Twinkle")]
		SpecialTwinkle,

		[Description("Special Sparkle")]
		SpecialSparkle,

		[Description("Special Snow")]
		SpecialSnow,

		[Description("Special Interlock")]
		SpecialInterlock,

		[Description("Special Switch")]
		SpecialSwitch,

		[Description("Special Slide")]
		SpecialSlide,

		[Description("Special Spray")]
		SpecialSpray,

		[Description("Special Starburst")]
		SpecialStarburst,

		[Description("Special Welcome")]
		SpecialWelcome,

		[Description("Special Slot machine")]
		SpecialSlotMachine,

		[Description("Special News flash")]
		SpecialNewsFlash,

		[Description("Special Trumpet animation")]
		SpecialTrumpetAnimation,

		[Description("Special Cycle colors")]
		SpecialCycleColors,

		// Special graphics

		[Description("Graphic Thankyou")]
		GraphicThankYou,

		[Description("Graphic No smoking")]
		GraphicNoSmoking,

		[Description("Graphic Don't drink drive")]
		GraphicDontDrinkDrive,

		[Description("Graphic RUnning animal")]
		GraphicRunningAnimal,

		[Description("Graphic Fish Animation")]
		GraphicFishAnimation,

		[Description("Graphic Fireworks")]
		GraphicFireworks,

		[Description("Graphic Turbo car")]
		GraphicTurboCar,

		[Description("Graphic Balloon animation")]
		GraphicBalloonAnimation,

		[Description("Graphic Cherry bomb")]
		GraphicCherryBomb
    }
}