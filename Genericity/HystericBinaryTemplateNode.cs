namespace CSharpCompilerTests.Genericity
{
    public class HystericBinaryTemplateNode<T1, T2>
    {
        public HystericBinaryTemplateNode<HystericBinaryTemplateNode<T1, T2>, HystericBinaryTemplateNode<T1, T2>> Child { get; set; }
    }
}
