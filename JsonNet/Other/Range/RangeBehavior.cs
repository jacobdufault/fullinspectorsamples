using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.Other.Range {
    [AddComponentMenu("Full Inspector Samples/Other/Range")]
    public class RangeBehavior : BaseBehavior<JsonNetSerializer> {
        [InspectorRange(1f, 3.5f)]
        public float Range;

        [InspectorRange(1f, 3.5f)]
        public int Range2;
    }
}