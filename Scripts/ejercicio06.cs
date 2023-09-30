using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio06 : MonoBehaviour
{

    public float distance = 5.0f;
    GameObject sphere;
    GameObject cube;
    GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindWithTag("orange_sphere");
        cube = GameObject.FindWithTag("green_cube");
        cylinder = GameObject.FindWithTag("blue_cylinder");        
    }

    // Update is called once per frame
    void Update()
    { 
        Vector3 spherePosition = sphere.transform.position;
        Vector3 cubePosition = cube.transform.position;
        Vector3 cylinderPosition = cylinder.transform.position;
        cube.transform.position = 
            new Vector3(spherePosition.x + distance, cubePosition.y, cubePosition.z);
        cylinder.transform.position = 
            new Vector3(spherePosition.x - distance, cylinderPosition.y, cylinderPosition.z);
    }
}
