using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestFooGameObject
{
    [UnityTest]
    public IEnumerator TestFooGameObjectWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        ReturnTrueComponent rtComponent = (new GameObject()).AddComponent<ReturnTrueComponent>();
        yield return null;
        Assert.AreEqual(true, rtComponent.foo());
    }
}
