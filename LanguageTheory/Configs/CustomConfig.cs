using CSharpCompilerTests.LanguageTheory.Abstractions;

namespace CSharpCompilerTests.LanguageTheory.Configs
{
    public class CustomConfig<TState, TLeftStack, TSymbol, TRightStack> : IConfig<TState, TLeftStack, TSymbol, TRightStack> where TState : State where TLeftStack : Stack where TSymbol : Symbol where TRightStack : Stack
    {
        public Secret Secret => new Secret();
    }
}
