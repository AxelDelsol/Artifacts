namespace Artifacts.Schemas;
public class Root<T>
{
    public T Data { get; set; } = default(T)!;
}
