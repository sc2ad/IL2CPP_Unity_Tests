using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviourGenerics : MonoBehaviour
{
    public void Start()
    {
        CallGenericOne();
        CallGenericTwo();
    }

    public void CallGenericOne()
    {
        // Compiles, should work
        var o = Resources.FindObjectsOfTypeAll<GameObject>();
    }

    public void CallGenericTwo()
    {
        // Compiles, should not work (error)
        var o = Resources.Load<GameObject>("testNonExistent");
    }
}
