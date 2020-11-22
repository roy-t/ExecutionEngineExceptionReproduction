using System.Collections.Generic;

namespace Library
{
    public abstract class ABase
    {
        public abstract IReadOnlyList<object> GetList(int index);

        public abstract object Get(int index);

        public abstract object this[int index] { get; }
    }

    public sealed class Concrete<T> : ABase
        where T : class
    {
        // This type of a covariant return types does not trigger an execution engine exception.
        public override IReadOnlyList<T> GetList(int index) => throw null;

        // This two types of a covariant return types do trigger an execution engine exception.

        public override T Get(int index) => throw null;

        public override T this[int index]
        {
            get
            {
                throw null;
            }
        }
    }
}
