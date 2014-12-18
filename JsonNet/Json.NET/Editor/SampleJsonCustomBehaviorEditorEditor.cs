using UnityEditor;
using UnityEngine;

namespace FullInspector.Samples.JsonNet {
    [CustomBehaviorEditor(typeof(SampleJsonCustomBehaviorEditor))]
    public class SampleJsonCustomBehaviorEditorEditor :
        BehaviorEditor<SampleJsonCustomBehaviorEditor> {

        protected override void OnEdit(Rect rect, SampleJsonCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            EditorGUI.HelpBox(rect, "This is the custom editor for SampleJsonCustomBehaviorEditor", MessageType.Info);
        }

        protected override float OnGetHeight(SampleJsonCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            return 30;
        }

        protected override void OnSceneGUI(SampleJsonCustomBehaviorEditor behavior) {
        }
    }

}