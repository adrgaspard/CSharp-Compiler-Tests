using CSharpCompilerTests.LanguageTheory.Abstractions;
using CSharpCompilerTests.LanguageTheory.DataStructures;
using CSharpCompilerTests.LanguageTheory.States;
using CSharpCompilerTests.LanguageTheory.Symbols;

namespace CSharpCompilerTests.LanguageTheory.Configs
{
    public class InitialConfig : IConfig<State1, EmptyStack, Symbol1, EmptyStack>
    {
        public Secret Secret => new Secret();
    }
}
