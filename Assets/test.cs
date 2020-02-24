using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class test : MonoBehaviour {

  
    
// Use this for initialization
void Start(){
        

        int[] points = { 5, 3, 7, 2, 9 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }


        for (int i=4; i>-1; i--)
        {
            Debug.Log(points[i]);
        
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}