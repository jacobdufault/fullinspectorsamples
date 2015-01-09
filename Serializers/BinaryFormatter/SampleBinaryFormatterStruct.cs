using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Structs")]
    public class SampleBinaryFormatterStruct : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct MyStruct {
            public int A;
            public float B;
            public string C;
        }

        public MyStruct StructValue;
    }
}