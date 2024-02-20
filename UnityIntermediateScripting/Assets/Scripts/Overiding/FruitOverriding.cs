using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitOverriding : MonoBehaviour
{
    public FruitOverriding()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit, and I am under the water.");
    }
}
