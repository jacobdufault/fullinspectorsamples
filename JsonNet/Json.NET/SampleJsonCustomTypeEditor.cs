using Newtonsoft.Json;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    public class CustomTypeEditorNonGeneric {
        public int Value;
    }

    public class CustomTypeEditorGeneric<T1, T2> {
        public T1 Value1;
        public T2 Value2;
    }

    public interface ICustomTypeEditorInherited { }
    public class CustomTypeEditorInheritedA : ICustomTypeEditorInherited { }
    public class CustomTypeEditorInheritedB : ICustomTypeEditorInherited { }

    [AddComponentMenu("Full Inspector Samples/Json.NET/Custom Type Editor")]
    public class SampleJsonCustomTypeEditor : BaseBehavior<JsonNetSerializer> {
        public CustomTypeEditorNonGeneric CustomTypeEditorNonGeneric;
        public CustomTypeEditorGeneric<float, string> CustomTypeEditorFloatString;
        public ICustomTypeEditorInherited ICustomTypeEditorInherited;
        public CustomTypeEditorInheritedA CustomTypeEditorInheritedA;
        public CustomTypeEditorInheritedB CustomTypeEditorInheritedB;
    }
}