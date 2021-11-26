namespace CSharpCompilerTests.Genericity
{
    public class TemplatedStack<TContent> : CuriouslyRecurringTemplatePattern<TemplatedStack<TContent>>
    {
        public TemplatedStack<TContent> Parent
        {
            get => Base;
            set => Base = value;
        }

        public TContent Content { get; protected set; }

        public TemplatedStack(TemplatedStack<TContent> parent, TContent content)
        {
            Parent = parent;
            Content = content;
        }
    }
}
