using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Dictionaries")]
    public class SampleJsonDictionaries : BaseBehavior<JsonNetSerializer> {
        public struct Container {
            public Dictionary<string, GameObject> StrGoDict;
        }

        public Dictionary<string, string> StrStrDict;

        public enum Enum { ValueA, ValueB, ValueC };
        public Dictionary<Enum, Transform> EnumTransformDict;
    }
}