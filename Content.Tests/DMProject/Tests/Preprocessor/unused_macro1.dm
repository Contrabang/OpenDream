// COMPILE ERROR

#pragma UnusedMacro error

#define MacroA 5
#define MacroB 4
#define Macro3 4

/proc/RunTest()
	ASSERT(MacroA == 5)

#undef MacroB