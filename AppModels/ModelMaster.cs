using System.Numerics;

namespace AppModels;

public sealed class ModelMaster
{
    public T CalcValues<T>(T value1, T value2)
        where T : INumber<T>
    {
        return value1 * value2;
    }
}
