using UnityEngine;
using System.Collections;

public class MyComponent : MonoBehaviour {

    public int intVariable;
    public float floatVariable;
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
            return intVariable;
        }
        set // Write Only
        {
            intVariable = value;
        }
    }

    public void DoSomething()
    {
        intVariable++;
    }
}
