using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Simple Types")]
    public class SampleProtoSimpleTypes : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct StructContainer {
            [ProtoMember(1)]
            public int IntValue;
            [ProtoMember(2)]
            public float FloatValue;
            [ProtoMember(3)]
            public string StringValue;
            [ProtoMember(4)]
            public bool BoolValue;
        }

        public int IntValue;
        public float FloatValue;
        public string StringValue;
        public bool BoolValue;
        public StructContainer StructValue;
    }
}