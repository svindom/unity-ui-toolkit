using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ScriptingDemo : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/ScriptingDemo")]
    public static void ShowExample()
    {
        ScriptingDemo wnd = GetWindow<ScriptingDemo>();
        wnd.titleContent = new GUIContent("ScriptingDemo");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }
}
