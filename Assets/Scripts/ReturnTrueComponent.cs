using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTrueComponent : MonoBehaviour
{
    ReturnTrue rt;
    private void Start()
    {
        rt = new ReturnTrue();
    }
    public bool foo()
    {
        return rt.foo();
    }
}
