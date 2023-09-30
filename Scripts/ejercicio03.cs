using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio03 : MonoBehaviour
{
    
    public Vector3 firstVector;
    public Vector3 secondVector;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"First vector magnitude: {firstVector.magnitude}");
        Debug.Log($"Second vector magnitude: {secondVector.magnitude}");
        Debug.Log($"The angle they form: {Vector3.Angle(firstVector, secondVector)}");
        Debug.Log($"Their distance: {Vector3.Distance(firstVector, secondVector)}");
        Vector3 result = ((firstVector[1] >= secondVector[1])? firstVector: secondVector);
        Debug.Log($"The higher vector is: {result}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
