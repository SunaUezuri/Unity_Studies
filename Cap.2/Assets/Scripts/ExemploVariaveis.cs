using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploVariaveis : MonoBehaviour
{
  
    // Criando algumas variáveis
    // [tipo] [nome] = [valor]

    int idade = 40;
    
    /*
    *int - numeros inteiros
    *float - numeros reais
    *string - texto
    *bool - valores verdadeiro ou falso    
    */

    string nome = "Raphael";
    float altura;
    bool olhosAzuis = true; 

    void Start()
    {
        altura = 1.25f;
        
        print(nome + " Você tem " + altura + "m");

        if (olhosAzuis == true){
            print("Você possui olhos azuis");
        } else {
            print("Você não possui olhos azuis");
        }
    }
}
