using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio05 : MonoBehaviour
{

    public GameObject object1;
    public GameObject object2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        double distance1 = Vector3.Distance(transform.position, object1.transform.position);
        Debug.Log($"Distance from {name} to {object1.name} is: {distance1} ");
        double distance2 = Vector3.Distance(transform.position, object2.transform.position);
        Debug.Log($"Distance from {name} to {object2.name} is: {distance2} ");        
    }
}
