using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploRelacionais : MonoBehaviour
{
    
    public int a, b;

    float nota1, nota2, nota3, media;

    // Comparando valores inteiros com operadores relacionais
    /*
    * == igualdade
    * != diferentes
    * > maior
    * < menor
    * >= maior ou igual
    * <= menor ou igual
    */

    void Start()
    {
        nota1 = 5.5f;
        nota2 = 8.7f;
        nota3 = 4.5f;

        media = (nota1 + nota2 + nota3)/3;

        if (media >= 6){
            print("Média: " + media + "\nAprovado!");
        } else {
            print("Média: " + media + "\nReprovado!");
        }
    }

}
