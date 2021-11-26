using CSharpCompilerTests.LanguageTheory.Abstractions;
using CSharpCompilerTests.LanguageTheory.Symbols;

namespace CSharpCompilerTests.LanguageTheory.DataStructures
{
    public class EmptyStack : Stack<Symbol1, EmptyStack>
    {
    }
}
