using ProtoBuf;
using System.Collections.Generic;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Lists")]
    public class SampleProtoLists : BaseBehavior<ProtoBufNetSerializer> {
        [ProtoContract]
        public struct Container {
            [ProtoMember(1)]
            public List<Transform> SubTransformList;

            [ProtoContract]
            [ProtoInclude(1, typeof(DerivedA))]
            [ProtoInclude(2, typeof(DerivedB))]
            public interface IFace { }
            [ProtoContract]
            public class DerivedA : IFace { [ProtoMember(1)] public int A; }
            [ProtoContract]
            public class DerivedB : IFace { [ProtoMember(1)] public string B; }

            [ProtoMember(2)]
            public List<IFace> SubInterfaceList;
        }

        public List<int> IntList;
        public int[] IntArray;
    }
}