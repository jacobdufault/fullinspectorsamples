using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Properties")]
    public class SampleBinaryFormatterProperties : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct Container {
            public int SubValue { get; set; }
        }

        public int Value { get; set; }
        public Container ContainedValue { get; set; }
    }
}