using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [AddComponentMenu("Full Inspector Samples/Binary Formatter/Inheritance")]
    public class SampleBinaryFormatterInheritance : BaseBehavior<BinaryFormatterSerializer> {

        // interface
        public interface IFace { }
        [Serializable]
        public class DerivedIFaceA : IFace { public int A; }
        [Serializable]
        public class DerivedIFaceB : IFace { public string B; }

        public IFace Interface;
        public List<IFace> InterfaceList;

        // abstract base class
        [Serializable]
        public abstract class AbstractType { }
        [Serializable]
        public class DerivedAbstractA : AbstractType { public int A; }
        [Serializable]
        public class DerivedAbstractB : AbstractType { public string B; }

        public AbstractType AbstractValue;
        public List<AbstractType> AbstractTypeList;

        // class with derived types
        [Serializable]
        public abstract class BaseType { }
        [Serializable]
        public class DerivedBaseA : BaseType { public int A; }
        [Serializable]
        public class DerivedBaseB : BaseType { public string B; }

        public BaseType BaseValue;
        public List<BaseType> BaseTypeList;
    }
}