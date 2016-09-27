using UnityEngine;
using System.Collections;

[AddComponentMenu("MyAsset")]
public class MyAsset : ScriptableObject
{

    public int invar = 0;
    public float floatvar = 0f;

    public void Revert()
    {
        invar = 0;
        floatvar = 0f;
    }
}
