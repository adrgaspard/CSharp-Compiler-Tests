using CSharpCompilerTests.LanguageTheory.Configs;

namespace CSharpCompilerTests.LanguageTheory.Abstractions
{
    public interface IChallenge
    {
        FinalConfig Run(InitialConfig config);
    }
}
