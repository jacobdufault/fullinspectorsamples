using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Properties")]
    public class SampleProtoProperties : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct Container {
            [ProtoMember(1)]
            public int SubValue { get; set; }
        }

        public int Value { get; set; }
        public Container ContainedValue { get; set; }
    }
}