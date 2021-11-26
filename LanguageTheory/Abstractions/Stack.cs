namespace CSharpCompilerTests.LanguageTheory.Abstractions
{
    public abstract class Stack {}

    public abstract class Stack<TSymbol, TRestStack> : Stack where TSymbol : Symbol
    {
    }
}
