using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    public class GenericHolder<T1> {
        public T1 Value;
    }

    public struct GenericHolder<T1, T2> {
        public T1 Value1;
        public T2 Value2;
    }

    [AddComponentMenu("Full Inspector Samples/Json.NET/Generics")]
    public class SampleJsonGenerics : BaseBehavior<JsonNetSerializer> {
        public GenericHolder<int> GenericInt;
        public GenericHolder<int, string> GenericIntString;
        public GenericHolder<GenericHolder<int>> GenericGenericInt;
    }
}