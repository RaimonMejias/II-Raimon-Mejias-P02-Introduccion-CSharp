using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio01 : MonoBehaviour
{

    public int minValue = 0;
    public int maxValue = 25;
    public int size = 50;
    public int flag = 15;
    int[] randomNumbers;

    // Start is called before the first frame update
    void Start()
    {
        randomNumbers = new int[size];
        string topNumbers = "";
        for (int i = 0; i < size; i++) {
            randomNumbers[i] = UnityEngine.Random.Range(minValue, maxValue);
            if (randomNumbers[i] > flag) { topNumbers += $"{randomNumbers[i]} "; }
        }
        string numbers = "El array de números aleatorios es: ";
        foreach(int number in randomNumbers) { numbers += $"{number} "; }
        Debug.Log(topNumbers);
        Debug.Log(numbers);
    }

    // Update is called once per frame
    void Update()
    {
        int index = UnityEngine.Random.Range(0, size - 1);
        randomNumbers[index] = UnityEngine.Random.Range(minValue, maxValue);
        if (randomNumbers[index] > flag) { Debug.Log(randomNumbers[index]); }
    }
}
