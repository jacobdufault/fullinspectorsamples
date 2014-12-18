using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Lists")]
    public class SampleBinaryFormatterLists : BaseBehavior<BinaryFormatterSerializer> {
        [Serializable]
        public struct Container {
            public List<Transform> SubTransformList;
            public interface IFace { }
            [Serializable]
            public class DerivedA : IFace { public int A; }
            [Serializable]
            public class DerivedB : IFace { public string B; }

            public List<IFace> SubInterfaceList;
        }

        public List<int> IntList;
        public int[] IntArray;
    }
}