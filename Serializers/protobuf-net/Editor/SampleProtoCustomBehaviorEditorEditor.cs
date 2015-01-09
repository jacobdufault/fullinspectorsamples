using UnityEditor;
using UnityEngine;

namespace FullInspector.Samples.ProtoBufNet {
    [CustomBehaviorEditor(typeof(SampleProtoCustomBehaviorEditor))]
    public class SampleProtoCustomBehaviorEditorEditor :
        BehaviorEditor<SampleProtoCustomBehaviorEditor> {

        protected override void OnEdit(Rect rect, SampleProtoCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            EditorGUI.HelpBox(rect, "This is the custom editor for SampleProtoCustomBehaviorEditor", MessageType.Info);
        }

        protected override float OnGetHeight(SampleProtoCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            return 30;
        }

        protected override void OnSceneGUI(SampleProtoCustomBehaviorEditor behavior) {
        }
    }

}