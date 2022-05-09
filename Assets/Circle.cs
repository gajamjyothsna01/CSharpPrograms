using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] int radius;
    float area;
    // Start is called before the first frame update
    void Start()
    {

        // calculate area
        // note that we're using UnityEngine Mathf instead of System Math
        area = Mathf.PI * Mathf.Pow(radius, 2);


      
    }

    // Update is called once per frame
    void Update()
    {
        // scale circle sprite based on radius
        Vector3 scale = transform.localScale;
        scale.x *= radius;
        scale.y *= radius;
        transform.localScale = scale;

        // print radius and area
        print("Radius: " + radius + ", Area: " + area);
    }
}
