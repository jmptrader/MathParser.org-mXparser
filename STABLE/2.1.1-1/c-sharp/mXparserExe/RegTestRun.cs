﻿using System;
using org.mariuszgromada.math.mxparser.regressiontesting;

namespace mXparserExe
{
    class RegTestRun
    {
        public static void Main(String[] args)
        {
            RegTestExpression.Start();
            RegTestExpressionV2.Start();
            RegTestExpressionAPI.Start();
            RegTestSyntax.Start();
            PerformanceTests.Start();
        }
    }
}
