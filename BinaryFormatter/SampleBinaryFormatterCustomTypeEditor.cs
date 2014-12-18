using System;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [Serializable]
    public class CustomTypeEditorNonGeneric {
        public int Value;
    }

    [Serializable]
    public class CustomTypeEditorGeneric<T1, T2> {
        public T1 Value1;
        public T2 Value2;
    }

    public interface ICustomTypeEditorInherited { }
    [Serializable]
    public class CustomTypeEditorInheritedA : ICustomTypeEditorInherited { }
    [Serializable]
    public class CustomTypeEditorInheritedB : ICustomTypeEditorInherited { }

    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Custom Type Editor")]
    public class SampleBinaryFormatterCustomTypeEditor : BaseBehavior<BinaryFormatterSerializer> {
        public CustomTypeEditorNonGeneric CustomTypeEditorNonGeneric;
        public CustomTypeEditorGeneric<float, string> CustomTypeEditorFloatString;
        public ICustomTypeEditorInherited ICustomTypeEditorInherited;
        public CustomTypeEditorInheritedA CustomTypeEditorInheritedA;
        public CustomTypeEditorInheritedB CustomTypeEditorInheritedB;
    }
}