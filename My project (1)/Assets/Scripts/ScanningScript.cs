using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanningScript : MonoBehaviour
{

    public TestMarkerTracking TestMarkerTracking;

    public static List<string> ingredients = new List<string>(); //list of ingredients where items that are detected are brought in

    // Update is called once per frame
    void Update()
    {
        string newDetected = TestMarkerTracking.imageName;
        ingredients.Add(newDetected);
    }
}
