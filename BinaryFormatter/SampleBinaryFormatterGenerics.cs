using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [Serializable]
    public class GenericHolder<T1> {
        public T1 Value;
    }

    [Serializable]
    public struct GenericHolder<T1, T2> {
        public T1 Value1;
        public T2 Value2;
    }

    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Generics")]
    public class SampleBinaryFormatterGenerics : BaseBehavior<BinaryFormatterSerializer> {
        public GenericHolder<int> GenericInt;
        public GenericHolder<int, string> GenericIntString;
        public GenericHolder<GenericHolder<int>> GenericGenericInt;
    }
}