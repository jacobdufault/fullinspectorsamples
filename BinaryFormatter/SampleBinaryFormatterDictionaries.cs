using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Dictionaries")]
    public class SampleBinaryFormatterDictionaries : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct Container {
            public Dictionary<string, GameObject> StrGoDict;
        }

        public Dictionary<string, string> StrStrDict;

        [Serializable]
        public enum Enum { ValueA, ValueB, ValueC };
        public Dictionary<Enum, Transform> EnumTransformDict;
    }
}