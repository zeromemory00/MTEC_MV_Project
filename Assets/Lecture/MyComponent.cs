using UnityEngine;
using System.Collections;

[AddComponentMenu("MyComponent")]

public class MyComponent : MonoBehaviour {

    public int intVariable;
    public float floatVariable;
    public GameObject[] GameObject;

   [SerializeField]
    private int _intVar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int IntVar //Property
    {
        get // read Only
        {
            //return intVariable;
            return _intVar;
        }
        set // Write Only
        {
            //intVariable = value;
            _intVar = value;
        }
    }

    public void DoSomething()
    {
        intVariable++;
    }
}
