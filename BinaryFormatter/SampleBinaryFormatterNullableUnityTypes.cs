using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Nullable Unity Types")]
    public class SampleBinaryFormatterNullableUnityTypes : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct UnityTypesContainer {
            public Bounds? Bounds;
            public Color? Color;
            // not currently supported, sorry! public AnimationCurve AnimationCurve;
            public Vector2? Vector2;
            public Vector3? Vector3;
            public Vector4? Vector4;
            public LayerMask? LayerMask;
        }

        public Bounds? Bounds;
        public Color? Color;
        // not currently supported, sorry! public AnimationCurve AnimationCurve;
        public Vector2? Vector2;
        public Vector3? Vector3;
        public Vector4? Vector4;
        public LayerMask? LayerMask;

        public UnityTypesContainer UnityTypes;
    }
}