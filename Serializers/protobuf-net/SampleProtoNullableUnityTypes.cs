using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Nullable Unity Types")]
    public class SampleProtoNullableUnityTypes : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct UnityTypesContainer {
            [ProtoMember(1)]
            public Bounds? Bounds;

            [ProtoMember(2)]
            public Color? Color;

            [ProtoMember(3)]
            public Vector2? Vector2;

            [ProtoMember(4)]
            public Vector3? Vector3;

            [ProtoMember(5)]
            public Vector4? Vector4;

            [ProtoMember(6)]
            public LayerMask? LayerMask;
        }

        public UnityTypesContainer UnityTypes;

        public Bounds? Bounds;
        public Color? Color;
        public Vector2? Vector2;
        public Vector3? Vector3;
        public Vector4? Vector4;
        public LayerMask? LayerMask;
    }
}