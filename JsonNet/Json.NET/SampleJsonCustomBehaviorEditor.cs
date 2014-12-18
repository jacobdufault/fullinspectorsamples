
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Custom Behavior Editor")]
    public class SampleJsonCustomBehaviorEditor : BaseBehavior<JsonNetSerializer> {
        // neither of these values will be shown in the inspector because there is a custom editor
        // for this behavior
        public int A;
        public float B;
    }
}