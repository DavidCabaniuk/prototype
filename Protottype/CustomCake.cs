namespace Protottype;

public class CustomCake(string flavor, string frosting, string decorations) : ICakePrototype
{
    public string Flavor { get; set; } = flavor;
    public string Frosting { get; set; } = frosting;
    public string Decorations { get; set; } = decorations;

    /// <summary>
    /// Clone method implementation
    /// </summary>
    /// <returns></returns>
    public ICakePrototype Clone()
    {
        // Performs a shallow copy of the object
        return (ICakePrototype)this.MemberwiseClone();
    }

    /// <summary>
    /// For displaying cake details
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Cake with {Flavor} flavor, {Frosting} frosting, and decorated with {Decorations}.";
    }
}