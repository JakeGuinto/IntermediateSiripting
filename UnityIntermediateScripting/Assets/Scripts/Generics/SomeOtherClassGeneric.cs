using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGeneric : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClassGenerics myClass = new SomeClassGenerics();
        myClass.GenericMethod<int>(5);
    }
}
