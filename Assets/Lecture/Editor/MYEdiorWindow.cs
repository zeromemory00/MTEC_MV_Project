using UnityEngine;
using UnityEditor;
using System.Collections;

public class MYEdiorWindow : EditorWindow
{
    [MenuItem("MyMenu/MyMenu")]
    public static void ShowWindow() { EditorWindow.GetWindow(typeof(MYEdiorWindow), false, "MyWindow", false); }


     [MenuItem("MyMenu/AddMyComponent", true)]
     public static bool CheckAddMyComponent() {
         if (Selection.activeGameObject != null)
             return true;
         else
             return false;
     }


     [MenuItem("MyMenu/AddMyComponent")]
     public static void AddMyComponent()
     {
         if (CheckAddMyComponent()/*Selection.activeGameObject != null*/) 
             Selection.activeGameObject.AddComponent<MyComponent>();
     }


	void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Button("My Button");
        GUILayout.Button("My Button"); 
        GUILayout.Button("My Button");
        GUILayout.EndHorizontal();
        GUILayout.Button("My Button");

        Rect rectGUI1 = new Rect(100, 100, 100, 30);
        if (Selection.activeGameObject == null)
        {
            GUI.Label(rectGUI1, "No Selection");
        }

        else
        {
            GUI.Label(rectGUI1, Selection.activeGameObject.name);

            Rect rectGUI = new Rect(100, 300, 100, 50);
            
            if(GUI.Button(rectGUI, "우아아앙") == true)
                Selection.activeGameObject.AddComponent<MyComponent>();
        }



        if (Event.current.button == 1)
        {
            if (Event.current.type == EventType.MouseUp)
            {
                GenericMenu contextMenu = new GenericMenu();
                contextMenu.AddItem(new GUIContent("Menu 1"), false, DoMenu1);
                contextMenu.AddItem(new GUIContent("Menu 2"), false, DoMenu2);
                contextMenu.ShowAsContext();
            }
        }

      

    
}
    void DoMenu1()
    {
        Debug.Log("메뉴 하나");
    }
    void DoMenu2()
    {
        Debug.Log("메뉴 둘");
    }
}
