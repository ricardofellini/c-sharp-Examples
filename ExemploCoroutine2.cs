using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine2 : MonoBehaviour {



    int n; // declara a variavel N
    IEnumerator Aleatorio() { 
 
    n = Random.Range(0,100); // a variavel N recebe um valor aleatorio
    yield return new WaitForSeconds(2f); // fica em pausa 2 segundos

    print(n); // imrprime N na tela
}



    private void Start()
    {
        StartCoroutine (Aleatorio()); // starta a coroutine que abrimos antes chamada aleatorio



    }

}
