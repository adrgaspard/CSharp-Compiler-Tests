using static CSharpCompilerTests.SATSolver.BooleanOperations;

namespace CSharpCompilerTests.SATSolver.BooleanStates
{
    public static class SATCompilerTests
    {
        /// <summary>
        /// Solve a 3-SAT problem with compilation : States that 3 requests fit into 2 answer (obviously false).
        /// If no error on compile : The model has an unique solution (represented by the compilation result).
        /// If conversion error on compile ("False can not be converted to True") : The model has no solution.
        /// If ambiguity error on compile : The model has many solutions.
        /// </summary>
        public static void SATResolutionTest()
        {
            /*
            // Request r1 can be assigned to answer a1 or answer a2.
            Variable(r1_with_a1 => Variable(r1_with_a2 =>

            // Request r2 can be assigned to answer a1 or answer a2.
            Variable(r2_with_a1 => Variable(r2_with_a2 =>

            // Request r3 can be assigned to answer a1 or answer a2.
            Variable(r3_with_a1 => Variable(r3_with_a2 =>
            {
                // Every request has at least one answer.
                Or(r1_with_a1, r1_with_a2);
                Or(r2_with_a1, r2_with_a2);
                Or(r3_with_a1, r3_with_a2);

                // The answer a1 can only be assigned to one request maximum.
                Or(Not(r1_with_a1), Not(r2_with_a1));
                Or(Not(r1_with_a1), Not(r3_with_a1));
                Or(Not(r2_with_a1), Not(r3_with_a1));

                // The answer a2 can only be assigned to one request maximum.
                Or(Not(r1_with_a2), Not(r2_with_a2));
                Or(Not(r1_with_a2), Not(r3_with_a2));
                Or(Not(r2_with_a2), Not(r3_with_a2));

                return null;
            }))))));
            */
        }

        /// <summary>
        /// Forces the compiler to bruteforce all the overloads.
        /// Complexity : T^N
        /// T : number of overloadable types (only 2 in our case : True and False)
        /// N : number of variables (24 in our case : x1, ..., x24)
        /// </summary>
        public static void OverloadBruteForce()
        {
            /*
            Variable(x1 => Variable(x2 => Variable(x3 => Variable(x4 => Variable(x5 => Variable(x6 => Variable(x7 => Variable(x8 => Variable(x9 => Variable(x10 => Variable(x11 => Variable(x12 => Variable(x13 => Variable(x14 => Variable(x15 =>Variable(x16 => Variable(x17 => Variable(x18 => Variable(x19 => Variable(x20 => Variable(x21 => Variable(x22 => Variable(x23 => Variable(x24 => null))))))))))))))))))))))));
            */
        }
    }
}
