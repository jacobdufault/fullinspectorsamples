using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Structs")]
    public class SampleJsonStruct : BaseBehavior<JsonNetSerializer> {
        public struct MyStruct {
            public int A;
            public float B;
            public string C;
        }

        public MyStruct StructValue;
    }
}