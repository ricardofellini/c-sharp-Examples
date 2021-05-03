using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine3 : MonoBehaviour {

    int n = 0;

    
    IEnumerator Contador() { // funcao da couroutine e nome dela 
        print("Tempo atual = " + n); // exibe o valor de N antes da execucao da coroutine
        yield return new WaitForSeconds(1f); // pausa a execucao da coroutine por 2 s
        n++; // incrementa ou seja soma 0,1,2,3,4 e em diante

        if (n <= 10) // se a variavel N for menor ou igual a 10 para
        {

            StartCoroutine(Contador()); // starta
        }
    }
	void Start () {
        StartCoroutine(Contador());// starta

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
