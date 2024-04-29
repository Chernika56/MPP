namespace FakerLab.Generators
{
    public interface IGenerator<T>
    {
        T GetValue();
    }
}
