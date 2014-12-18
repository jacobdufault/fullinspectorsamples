using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Attributes")]
    public class SampleBinaryFormatterAttributes : BaseBehavior<BinaryFormatterSerializer> {
        [InspectorComment("Welcome! Please click on the game object of choice to see how to serialize and inspect objects relating to the specified Unity type.")]
        public int ReadMeFirst;

        [InspectorTooltip("Hey, there. This is a tooltip from an attribute!")]
        public int HoverOverMe;

        [InspectorMargin(50)]
        [InspectorComment("Wow! I'm pretty far away! Thanks Margin!")]
        public int WayBelow;
    }
}