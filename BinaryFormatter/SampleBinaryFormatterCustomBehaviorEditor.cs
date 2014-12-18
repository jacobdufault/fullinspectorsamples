using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Custom Behavior Editor")]
    public class SampleBinaryFormatterCustomBehaviorEditor : BaseBehavior<BinaryFormatterSerializer> {
        // neither of these values will be shown in the inspector because there is a custom editor
        // for this behavior
        public int A;
        public float B;
    }
}