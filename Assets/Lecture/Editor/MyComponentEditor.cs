using UnityEngine;
using System.Collections;
using UnityEditor; //using namaspace for Editor 
using UnityEditor.SceneManagement;

[CustomEditor(typeof(MyComponent))] //attribute. 매소드에 대해서 속성을 정의 해주는 [] 
public class MyComponentEditor : Editor {

    SerializedProperty intVariable;
    //SerializedProperty _intVar;
    SerializedProperty floatVariable;
    SerializedProperty gameObject;

    void OnEnable () //Start
    {
        intVariable = serializedObject.FindProperty("intVariable");
     //   _intVar = serializedObject.FindProperty("_intVar");
        floatVariable = serializedObject.FindProperty("floatVariable");
        gameObject = serializedObject.FindProperty("gameObject");

    }

    public override void OnInspectorGUI() //Update
    {
      serializedObject.Update();

      EditorGUILayout.PropertyField(intVariable, new GUIContent("Var1"));
      EditorGUILayout.PropertyField(floatVariable, new GUIContent("Var2")); //
      EditorGUILayout.PropertyField(gameObject, new GUIContent("List"), true);



      serializedObject.ApplyModifiedProperties(); 

      //표시하기 위한 코드
      MyComponent MyComponent = (MyComponent)target; //★★★★★
      MyComponent.intVariable = EditorGUILayout.IntField("Int Variable", MyComponent.intVariable); //int variable 표시
      MyComponent.floatVariable = EditorGUILayout.Slider("Float Variable",MyComponent.floatVariable, 0f, 100f); //float variable 표시
      //MyComponent.IntVar = EditorGUILayout.IntField("Int Var", MyComponent.IntVar); // int var property 표시


      int a = EditorGUILayout.IntField("Int Var", MyComponent.IntVar);
      if (a != MyComponent.IntVar)
      {
          MyComponent.IntVar = a;
          EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
      }


      if(GUILayout.Button("Do Something") == true) // do something 버튼
      {
          MyComponent.DoSomething();
          EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
      }

      //if (GUILayout.Button("Show My Window") == true) // do something 버튼
      //{
      //    MYEdiorWindow.ShowWindow();
      //}
    }
}
