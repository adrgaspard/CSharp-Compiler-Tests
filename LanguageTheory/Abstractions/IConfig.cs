namespace CSharpCompilerTests.LanguageTheory.Abstractions
{
    public interface IConfig { }

    public interface IConfig<TState, out TLeftStack, TSymbol, out TRightStack> : IConfig where TState : State where TLeftStack : Stack where TSymbol : Symbol where TRightStack : Stack
    {
        Secret Secret { get; }
    }
}
