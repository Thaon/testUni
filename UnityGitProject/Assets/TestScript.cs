using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
    public int fibonacciSteps = 5;
	// Use this for initialization
	void Start ()
    {
        int number = 0;
        int next = 1;
        for (int x = 0; x < fibonacciSteps; x++)
        {
            number += next + number;
            print(number);
        }
	}
}
