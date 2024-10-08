using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    
    public int num;

    void Start()
    {
        
        if(num >= 0 && num <= 10){
            print("Este número está entre 0 e 10");
        } else{
            print("Este número não está entre 0 e 10");
        }
    }

    
}
