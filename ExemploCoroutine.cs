using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine : MonoBehaviour {


    int n; // declara a variavel inteira chamada n

    void Start() { //inicia a funcao 
        StartCoroutine(Contar()); // inicia a funcao coroutine


    }
        IEnumerator Contar() { //inicia a funcao de retorno
        
            n++; // ++ como se fosse somar 1,2,3,4,5...
            print(n); // imprime o valor de N na tela
            yield return  new WaitForSeconds(5f); // comando para imprimir o proximo valor de N após 5 segundos o 5F

            StartCoroutine (Contar()); //starta a corutine


        }




    void Update()
    {



    }
	}
