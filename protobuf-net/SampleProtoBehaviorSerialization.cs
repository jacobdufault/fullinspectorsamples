using ProtoBuf;
using System;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [AddComponentMenu("Full Inspector Samples/protobuf-net/Behavior Serialization")]
    public class SampleProtoBehaviorSerialization : BaseBehavior<ProtoBufNetSerializer> {
        // Lets create a type that Unity cannot serialize
        [ProtoContract]
        public struct NotSerializableByUnity {
            [ProtoMember(1)]
            public int Value;
        }

        // All of these types will be serialized.
        public NotSerializableByUnity Serialized0;
        [SerializeField]
        public NotSerializableByUnity Serialized1;
        [ShowInInspector]
        [SerializeField]
        protected internal NotSerializableByUnity Serialized2;
        [ShowInInspector]
        [SerializeField]
        internal NotSerializableByUnity Serialized3;
        [ShowInInspector]
        [SerializeField]
        protected NotSerializableByUnity Serialized4;
        [ShowInInspector]
        [SerializeField]
        private NotSerializableByUnity Serialized5;

        // None of these types will be serialized
        [NonSerialized]
        public NotSerializableByUnity NotSerialized0;
        [ShowInInspector]
        protected internal NotSerializableByUnity NotSerialized1;
        [ShowInInspector]
        internal NotSerializableByUnity NotSerialized2;
        [ShowInInspector]
        protected NotSerializableByUnity NotSerialized3;
        [ShowInInspector]
        private NotSerializableByUnity NotSerialized4;

        // The same rules apply to properties
        public NotSerializableByUnity Serialized6 { get; set; }
        [SerializeField]
        public NotSerializableByUnity Serialized7 { get; set; }
        [NotSerialized] // identical to NonSerialized, just also usable on properties
        public NotSerializableByUnity NotSerialized5 { get; set; }
        [ShowInInspector]
        private NotSerializableByUnity NotSerialized6 { get; set; }
    }
}