using CSharpCompilerTests.LanguageTheory.Abstractions;
using CSharpCompilerTests.LanguageTheory.Configs;
using CSharpCompilerTests.LanguageTheory.States;
using CSharpCompilerTests.LanguageTheory.Symbols;

namespace CSharpCompilerTests.LanguageTheory
{
    public static class AutomatonSchema
    {
        public static FinalConfig Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State3, TLeftStack, Symbol1, Stack<TSymbol, TRightStack>> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new FinalConfig();

        public static IConfig<State2, Stack<Symbol2, TLeftStack>, TSymbol, TRightStack> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State1, TLeftStack, Symbol1, Stack<TSymbol, TRightStack>> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State2, Stack<Symbol2, TLeftStack>, TSymbol, TRightStack>();

        public static IConfig<State2, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State1, Stack<TSymbol, TLeftStack>, Symbol2, TRightStack> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State2, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>>();

        public static IConfig<State1, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State2, Stack<TSymbol, TLeftStack>, Symbol1, TRightStack> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State1, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>>();

        public static IConfig<State3, TLeftStack, TSymbol, Stack<Symbol1, TRightStack>> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State2, Stack<TSymbol, TLeftStack>, Symbol2, TRightStack> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State3, TLeftStack, TSymbol, Stack<Symbol1, TRightStack>>();

        public static IConfig<State4, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State3, Stack<TSymbol, TLeftStack>, Symbol2, TRightStack> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State4, TLeftStack, TSymbol, Stack<Symbol2, TRightStack>>();

        public static IConfig<State4, Stack<Symbol2, TLeftStack>, TSymbol, TRightStack> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State4, TLeftStack, Symbol1, Stack<TSymbol, TRightStack>> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State4, Stack<Symbol2, TLeftStack>, TSymbol, TRightStack>();

        public static IConfig<State1, Stack<Symbol1, TLeftStack>, TSymbol, TRightStack> Step<TLeftStack, TRightStack, TSymbol>(
            this IConfig<State4, TLeftStack, Symbol2, Stack<TSymbol, TRightStack>> config)
            where TLeftStack : Stack where TRightStack : Stack where TSymbol : Symbol
        => new CustomConfig<State1, Stack<Symbol1, TLeftStack>, TSymbol, TRightStack>();
    }
}

