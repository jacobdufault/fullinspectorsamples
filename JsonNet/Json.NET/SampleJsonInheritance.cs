using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [AddComponentMenu("Full Inspector Samples/Json.NET/Inheritance")]
    public class SampleJsonInheritance : BaseBehavior<JsonNetSerializer> {

        // interface
        public interface IFace { }
        public class DerivedIFaceA : IFace { public int A; }
        public class DerivedIFaceB : IFace { public string B; }

        public IFace Interface;
        public List<IFace> InterfaceList;

        // abstract base class
        public abstract class AbstractType { }
        public class DerivedAbstractA : AbstractType { public int A; }
        public class DerivedAbstractB : AbstractType { public string B; }

        public AbstractType AbstractValue;
        public List<AbstractType> AbstractTypeList;

        // class with derived types
        public abstract class BaseType { }
        public class DerivedBaseA : BaseType { public int A; }
        public class DerivedBaseB : BaseType { public string B; }

        public BaseType BaseValue;
        public List<BaseType> BaseTypeList;
    }
}