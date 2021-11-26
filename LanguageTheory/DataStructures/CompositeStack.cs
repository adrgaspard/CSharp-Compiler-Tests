using CSharpCompilerTests.LanguageTheory.Abstractions;

namespace CSharpCompilerTests.LanguageTheory.DataStructures
{
    public class CompositeStack<TSymbol, TRestStack> : Stack<TSymbol, TRestStack> where TSymbol : Symbol
    {
    }
}
