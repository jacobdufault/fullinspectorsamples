using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Nullable Unity Types")]
    public class SampleJsonNullableUnityTypes : BaseBehavior<JsonNetSerializer> {
        public struct UnityTypesContainer {
            public Bounds? Bounds;
            public Color? Color;
            public Vector2? Vector2;
            public Vector3? Vector3;
            public Vector4? Vector4;
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