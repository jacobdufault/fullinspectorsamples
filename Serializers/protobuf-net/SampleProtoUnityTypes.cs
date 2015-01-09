using ProtoBuf;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Unity Types")]
    public class SampleProtoUnityTypes : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct UnityTypesContainer {
            [ProtoMember(1)]
            public Bounds Bounds;

            [ProtoMember(2)]
            public Color Color;

            [ProtoMember(3)]
            public AnimationCurve AnimationCurve;

            [ProtoMember(4)]
            public Vector2 Vector2;

            [ProtoMember(5)]
            public Vector3 Vector3;

            [ProtoMember(6)]
            public Vector4 Vector4;

            [ProtoMember(7)]
            public LayerMask LayerMask;

            [ProtoMember(8)]
            public Gradient Gradient;
        }

        public UnityTypesContainer UnityTypes;
    }
}