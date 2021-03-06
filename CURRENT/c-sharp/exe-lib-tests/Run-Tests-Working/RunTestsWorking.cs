﻿using org.mariuszgromada.math.mxparser;
using org.mariuszgromada.math.mxparser.mathcollection;
using System;

namespace mxparser.runtests {
	class RunTestsWorking {
		static void Main(string[] args) {
			mXparser.disableUlpRounding();
			String expStr = "sum(n, 0, 10, if ( if( sin(n*pi/2) > 0, 1, 2) >= 2, 4, 2) )";
			Expression ee = new Expression(expStr);
			ee.setVerboseMode();
			double a = ee.calculate();
			mXparser.consolePrintln(a);
			mXparser.consolePrintln(MathFunctions.ulp(6.28318530717959));
			mXparser.consolePrintln(MathFunctions.ulpDecimalDigitsBefore(6.28318530717959));
			mXparser.consolePrintln(MathFunctions.round(6.28318530717959, 13));
		}
	}
}
