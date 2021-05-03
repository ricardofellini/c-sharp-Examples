using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine5 : MonoBehaviour
{

    int vezes;

    IEnumerator Estado()
    {

        vezes++;
        print("Ciclo atual " + vezes.ToString()); // registra a classe

        print("Estou parado ");
        yield return new WaitForSeconds(3.0f); // imprime o primeiro coroutine estou parado por 3 segundos

        print("Andando");
        yield return new WaitForSeconds(10.0f); // depois dos 3 segundos do estou parado imprime Andando e dura 10 segundos


        if (vezes < 3) // repete o processo 3x até o valor da variavel vezes for menor que 3 quando chegar no 3 executa outro comando
        {

            StartCoroutine(Estado());
        }

        else // aqui executa o print fim porque ja chegou no fim do processo  e o valor de vezes chegou a 3 como foi definido na funcao if
        {
            print("fim");

        }

    }
      void Start ()
        {

            StartCoroutine(Estado());

        }
    }



    
	
	

