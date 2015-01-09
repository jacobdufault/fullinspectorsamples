using FullInspector.Serializers.ProtoBufNet;
using ProtoBuf;
using ProtoBuf.Meta;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [ProtoContract]
    public class CustomTypeEditorNonGeneric {
        [ProtoMember(1)]
        public int Value;
    }

    [ProtoContract]
    public class CustomTypeEditorGeneric<T1, T2> {
        [ProtoMember(1)]
        public T1 Value1;
        [ProtoMember(2)]
        public T2 Value2;
    }

    [ProtoContract]
    [ProtoInclude(1, typeof(CustomTypeEditorInheritedA))]
    [ProtoInclude(2, typeof(CustomTypeEditorInheritedB))]
    public interface ICustomTypeEditorInherited { }
    [ProtoContract]
    public class CustomTypeEditorInheritedA : ICustomTypeEditorInherited { }
    [ProtoContract]
    public class CustomTypeEditorInheritedB : ICustomTypeEditorInherited { }

    [AddComponentMenu("Full Inspector Samples/protobuf-net/Custom Type Editor")]
    public class SampleProtoCustomTypeEditor : BaseBehavior<ProtoBufNetSerializer> {
        public CustomTypeEditorNonGeneric CustomTypeEditorNonGeneric;
        public CustomTypeEditorGeneric<float, string> CustomTypeEditorFloatString;
        public ICustomTypeEditorInherited ICustomTypeEditorInherited;
        public CustomTypeEditorInheritedA CustomTypeEditorInheritedA;
        public CustomTypeEditorInheritedB CustomTypeEditorInheritedB;
    }
}