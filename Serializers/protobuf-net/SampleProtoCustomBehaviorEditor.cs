using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Custom Behavior Editor")]
    public class SampleProtoCustomBehaviorEditor : BaseBehavior<ProtoBufNetSerializer> {
        // neither of these values will be shown in the inspector because there is a custom editor
        // for this behavior
        public int A;
        public float B;
    }
}