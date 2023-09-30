using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio08 : MonoBehaviour
{
    public float distance = 5.0f;
    GameObject[] spheres;
    GameObject cube;
    float[] distances;
    int arraySize = 0;

    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("second_group");
        cube = GameObject.FindWithTag("green_cube");
        foreach(GameObject sphere in spheres) { arraySize++; }
        distances = new float[arraySize];
    }

    // Update is called once per frame
    void Update()
    {   
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 0; i < arraySize; i++) {
            distances[i] = Vector3.Distance(spheres[i].transform.position, cube.transform.position);
            if (distances[i] <= distances[minIndex]) { minIndex = i; }
            if (distances[i] >= distances[maxIndex]) { maxIndex = i; }
        }
        spheres[minIndex].transform.position = spheres[minIndex].transform.position + new Vector3(0, distance, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {
           spheres[maxIndex].GetComponent<Renderer>().material.color = 
                new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1);            
        }
    }
}
