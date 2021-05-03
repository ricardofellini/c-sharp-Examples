using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine4 : MonoBehaviour {


    int n= 0;
     IEnumerator Contador()
    {
        print("Contador atual =  " + n);
        n++;
        yield return new WaitForSeconds(1f);
         
        if (n <= 5)
        {
            StartCoroutine(Contador());


        }



    }
	
	void Start () {

        StartCoroutine(Contador());
    }
	
	
	void Update () {
		
	}
}
