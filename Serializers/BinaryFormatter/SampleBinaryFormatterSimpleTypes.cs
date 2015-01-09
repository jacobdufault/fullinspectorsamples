using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Simple Types")]
    public class SampleBinaryFormatterSimpleTypes : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct StructContainer {
            public int IntValue;
            public float FloatValue;
            public string StringValue;
            public bool BoolValue;
        }

        public int IntValue;
        public float FloatValue;
        public string StringValue;
        public bool BoolValue;
        public StructContainer StructValue;
    }
}