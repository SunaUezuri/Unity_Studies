using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //String escolha para ser o parâmetro do switch
    public string escolha;


    void Start()
    {
        switch (escolha){

            case "iniciar":
                print("Iniciando o jogo");
                break;

            case "pausar":
                print("Jogo pausado");
                break;
            
            case "parar":
                print("Finalizando sessão...");
                break;

            default:
                print("Comando não encontrado: " + escolha);
                break;
        }
    }
}
