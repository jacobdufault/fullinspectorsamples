using FullInspector.Serializers.ProtoBufNet;
using ProtoBuf;
using ProtoBuf.Meta;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Dictionaries")]
    public class SampleProtoDictionaries : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct Container {
            [ProtoMember(1)]
            public Dictionary<string, GameObject> StrGoDict;
        }

        public Dictionary<string, string> StrStrDict;

        public enum Enum { ValueA, ValueB, ValueC };
        public Dictionary<Enum, Transform> EnumTransformDict;
    }
}