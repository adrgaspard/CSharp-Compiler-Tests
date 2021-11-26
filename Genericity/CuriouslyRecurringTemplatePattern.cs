namespace CSharpCompilerTests.Genericity
{
    public abstract class CuriouslyRecurringTemplatePattern<TDerived> where TDerived : CuriouslyRecurringTemplatePattern<TDerived>
    {
        protected TDerived Base { get; set; }
    }
}
