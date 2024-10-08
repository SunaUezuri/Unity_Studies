using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresMatematicos : MonoBehaviour
{
    
    //Criando as variáveis
    // "public" faz com que seja possível inserir valores por um meio externo
    // [acesso-Opcional] [tipo] [nome] = [valor-Opicional]
    public float nota1;
    public float nota2;
    public float nota3;
    float media;

    /*
    * Operadores matemáticos
    * + soma
    * - subtração
    * / divisão
    * * multiplicação
    */


    void Start()
    {
        media = (nota1 + nota2 + nota3) / 3;

        print(media);

    }

}
