using UnityEditor;
using UnityEngine;

namespace FullInspector.Samples.BinaryFormatterSample {
    [CustomBehaviorEditor(typeof(SampleBinaryFormatterCustomBehaviorEditor))]
    public class SampleBinaryFormatterCustomBehaviorEditorEditor :
        BehaviorEditor<SampleBinaryFormatterCustomBehaviorEditor> {

        protected override void OnEdit(Rect rect, SampleBinaryFormatterCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            EditorGUI.HelpBox(rect, "This is the custom editor for SampleBinaryFormatterCustomBehaviorEditor", MessageType.Info);
        }

        protected override float OnGetHeight(SampleBinaryFormatterCustomBehaviorEditor behavior, fiGraphMetadata metadata) {
            return 30;
        }

        protected override void OnSceneGUI(SampleBinaryFormatterCustomBehaviorEditor behavior) {
        }
    }

}