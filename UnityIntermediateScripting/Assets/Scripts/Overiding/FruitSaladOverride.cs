using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladOverride : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleOverride myApple = new AppleOverride();

        myApple.SayHello();
        myApple.Chop();

        FruitOverriding myFruit = new AppleOverride();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
