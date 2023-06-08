using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestFoo
{
    // A Test behaves as an ordinary method
    [Test]
    public void ExpectTrue()
    {
        // Use the Assert class to test conditions
        ReturnTrue returnTrueObject = new ReturnTrue();
        Assert.AreEqual(returnTrueObject.foo(), true);
    }
}
