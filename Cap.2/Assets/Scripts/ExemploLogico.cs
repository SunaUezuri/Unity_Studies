using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploLogico : MonoBehaviour
{

    int a, b, c;

    void Start()
    {
        a = 5;
        b = 10;
        c = a + b;

        print(a != b && a == b);
        print(a != c || c == a);

        /*
        * && - AND
        * || - OR
        */

    }

}
