[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class CustomAttribute<T> : Attribute
{
    public T Value { get; set; }

    public CustomAttribute(T value)
    {
        Value = value;
    }
}

[CustomAttribute<int>(123)]
class MinhaClasse
{
    [CustomAttribute<string>("Custom")]
    public void MeuMetodo()
    {
        // Método personalizado
    }
}