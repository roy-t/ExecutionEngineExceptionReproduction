namespace MiniEngine.Systems.Components
{
    public abstract class ABase
    {
        public abstract object this[int index] { get; }
    }

    public sealed class Concrete<T> : ABase
        where T : class
    {
        public override T this[int index]
        {
            get
            {
                throw null;
            }
        }
    }
}
