using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int radius;
        float area;
        //Circle with Radius 0
        radius = 0;
        area = (float)Mathf.PI * radius * radius;
        Debug.Log("Radius: " + radius + " " + "Area: " + area);
       // Debug.Log("Radius: {0}, Area: {1}", radius, area);
       // Debug.Log("Radius: {0}, Area: {1,5:N2}", radius, area);
    }
}
