using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    
    public int valor;

    void Start()
    {
        
        //Criando a função para dizer se o valor é negativo ou positivo
        if (valor >= 0){
            print("O valor de " + valor + " é positivo");
        } else {
            print("Este valor é negativo");
        }
    }

}
