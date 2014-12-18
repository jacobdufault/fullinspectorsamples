using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [ProtoContract]
    public class GenericHolder<T1> {
        [ProtoMember(1)]
        public T1 Value;
    }

    [ProtoContract]
    public struct GenericHolder<T1, T2> {
        [ProtoMember(1)]
        public T1 Value1;

        [ProtoMember(2)]
        public T2 Value2;
    }

    [AddComponentMenu("Full Inspector Samples/protobuf-net/Generics")]
    public class SampleProtoGenerics : BaseBehavior<ProtoBufNetSerializer> {
        public GenericHolder<int> GenericInt;
        public GenericHolder<int, string> GenericIntString;
        public GenericHolder<GenericHolder<int>> GenericGenericInt;
    }
}