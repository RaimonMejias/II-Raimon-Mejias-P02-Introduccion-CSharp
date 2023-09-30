using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio07 : MonoBehaviour
{

    GameObject cube;
    GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("green_cube");
        cylinder = GameObject.FindWithTag("blue_cylinder");   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Pulsada tecla A");
            cylinder.GetComponent<Renderer>().material.color = 
                new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {    
            Debug.Log("Pulsada tecla UpArrow");
            cube.GetComponent<Renderer>().material.color = 
                new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1);
        }
    }
}
