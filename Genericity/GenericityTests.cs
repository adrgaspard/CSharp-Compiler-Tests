using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerTests.Genericity
{
    public static class GenericityTests
    {
        /// <summary>
        /// Force the compiler to creates HUUUUUUUUUGE classes.
        /// Complexity : T^N
        /// T : Number of type arguments in the class (2 in our case : string and string)
        /// N : Number of consecutive Child calls (12 in our case).
        /// </summary>
        public static void BigGenericityTest()
        {
            /*
            HystericBinaryTemplateNode<string, string> node = new HystericBinaryTemplateNode<string, string>();
            var subNode = node.Child.Child.Child.Child.Child.Child.Child.Child.Child.Child.Child.Child;
            */
        }

        /// <summary>
        /// Code sample for exploit the CRTP. This sample shows how to create a stack of integers.
        /// </summary>
        public static void TemplatedStackTest()
        {
            TemplatedStack<int> list = new TemplatedStack<int>(
                new TemplatedStack<int>(
                    new TemplatedStack<int>(
                        new TemplatedStack<int>(
                            new TemplatedStack<int>(
                                new TemplatedStack<int>(
                                    new TemplatedStack<int>(
                                        new TemplatedStack<int>(
                                            new TemplatedStack<int>(
                                                new TemplatedStack<int>(
                                                    new TemplatedStack<int>(
                                                        new TemplatedStack<int>(
                                                            null,
                                                            42),
                                                        3),
                                                    8),
                                                -4),
                                            0),
                                        111),
                                    754),
                                1),
                            -89),
                        77),
                    1987),
                59);
            TemplatedStack<int> tmp = list;
            while (tmp is object)
            {
                Console.WriteLine(tmp.Content);
                tmp = tmp.Parent;
            }
        }
    }
}
