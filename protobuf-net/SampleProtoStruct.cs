using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Structs")]
    public class SampleProtoStruct : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct MyStruct {
            [ProtoMember(1)]
            public int A;
            [ProtoMember(2)]
            public float B;
            [ProtoMember(3)]
            public string C;
        }

        public MyStruct StructValue;
    }
}