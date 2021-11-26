using CSharpCompilerTests.SATSolver.BooleanStates;
using System;

namespace CSharpCompilerTests.SATSolver
{
    public static class BooleanOperations
    {
        public static True Or(True left, BooleanState right) => new True();

        public static True Or(False left, True right) => new True();

        public static True And(True left, True right) => new True();

        public static True Xor(True left, False right) => new True();

        public static True Xor(False left, True right) => new True();

        public static True Nor(False left, False right) => new True();

        public static True Nand(False left, BooleanState right) => new True();

        public static True Nand(True left, False right) => new True();

        public static True Xnor<TBool>(TBool left, TBool right) where TBool : BooleanState => new True();

        public static True Not(False obj) => new True();

        public static False Not(True obj) => new False();

        public static BooleanState Variable(Func<True, BooleanState> function) => null;

        public static BooleanState Variable(Func<False, BooleanState> function) => null;
    }
}
