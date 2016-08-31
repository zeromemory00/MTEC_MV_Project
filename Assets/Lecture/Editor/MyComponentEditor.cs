using UnityEngine;
using System.Collections;
using UnityEditor; //using namaspace for Editor 

[CustomEditor(typeof(MyComponent))] //attribute. 매소드에 대해서 속성을 정의 해주는 [] 
public class MyComponentEditor : Editor {

    void OnEnable () //Start
    {

    }

    public override void OnInspectorGUI() //Update
    {

      //표시하기 위한 코드
      MyComponent MyComponent = (MyComponent)target; //★★★★★
      MyComponent.intVariable = EditorGUILayout.IntField("Int Variable", MyComponent.intVariable); //int variable 표시
      MyComponent.floatVariable = EditorGUILayout.Slider("Float Variable",MyComponent.floatVariable, 0f, 100f); //float variable 표시
      MyComponent.IntVar = EditorGUILayout.IntField("Int Var", MyComponent.IntVar); // int var property 표시


      if(GUILayout.Button("Do Something") == true) // do something 버튼
      {
          MyComponent.DoSomething();
      }
    }
}
