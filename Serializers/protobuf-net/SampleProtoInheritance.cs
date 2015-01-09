using ProtoBuf;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Inheritance")]
    public class SampleProtoInheritance : BaseBehavior<ProtoBufNetSerializer> {
        [InspectorButton]
        public void PopulateLists() {
            InterfaceList.Add(new DerivedIFaceA());
            InterfaceList.Add(new DerivedIFaceB());

            AbstractTypeList.Add(new DerivedAbstractA());
            AbstractTypeList.Add(new DerivedAbstractB());

            BaseTypeList.Add(new BaseType());
            BaseTypeList.Add(new DerivedBaseA());
            BaseTypeList.Add(new DerivedBaseB());
        }

        // interface
        [ProtoContract]
        [ProtoInclude(1, typeof(DerivedIFaceA))]
        [ProtoInclude(2, typeof(DerivedIFaceB))]
        public interface IFace { }
        [ProtoContract]
        public class DerivedIFaceA : IFace { [ProtoMember(1)] public int A; }
        [ProtoContract]
        public class DerivedIFaceB : IFace { [ProtoMember(1)] public string B; }

        public IFace Interface;
        public List<IFace> InterfaceList;

        // abstract base class
        [ProtoContract]
        [ProtoInclude(1, typeof(DerivedAbstractA))]
        [ProtoInclude(2, typeof(DerivedAbstractB))]
        public abstract class AbstractType { }
        [ProtoContract]
        public class DerivedAbstractA : AbstractType { [ProtoMember(1)] public int A; }
        [ProtoContract]
        public class DerivedAbstractB : AbstractType { [ProtoMember(1)] public string B; }

        public AbstractType AbstractValue;
        public List<AbstractType> AbstractTypeList;

        // class with derived types
        [ProtoContract]
        [ProtoInclude(1, typeof(DerivedBaseA))]
        [ProtoInclude(2, typeof(DerivedBaseB))]
        public class BaseType { }
        [ProtoContract]
        public class DerivedBaseA : BaseType { [ProtoMember(1)] public int A; }
        [ProtoContract]
        public class DerivedBaseB : BaseType { [ProtoMember(1)] public string B; }

        public BaseType BaseValue;
        public List<BaseType> BaseTypeList;
    }
}