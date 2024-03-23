
#pragma UnusedMacro error

#define MacroA 5
#define MacroB 9


#ifdef SOME_NONSENSE
	#define OTHER MacroB
#else
	#define OTHER 6
#endif

/proc/RunTest()
	ASSERT(MacroA == 5)
	ASSERT(OTHER == 6)


#undef MacroB