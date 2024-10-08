using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedasVidas : MonoBehaviour
{
    
    public int moedas;
    public int vidas;

    void Update()
    {

        if (moedas == 100){
            vidas++;
            moedas = 0;
        } 

        //Exibir os valores no console
        print("Quantidade de moedas: " + moedas);
        print("Quantidade de vidas: " + vidas);

        // Acumula 1 na variável moedas
        moedas++;

    }

    
}
