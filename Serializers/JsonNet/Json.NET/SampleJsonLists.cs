using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Lists")]
    public class SampleJsonLists : BaseBehavior<JsonNetSerializer> {
        public struct Container {
            public List<Transform> SubTransformList;
            public interface IFace { }
            public class DerivedA : IFace { public int A; }
            public class DerivedB : IFace { public string B; }
            public List<IFace> SubInterfaceList;
        }

        public List<int> IntList;
        public int[] IntArray;
    }
}