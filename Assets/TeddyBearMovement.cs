using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBearMovement : MonoBehaviour
{
    public float moveUnitsPerSecond;
    public GameObject prefabExplosion;
   // public SpriteRenderer sprite;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;
        // get new horizontal position
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * moveUnitsPerSecond *
            Time.deltaTime;
        }
        // get new vertical position
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            position.y += verticalInput * moveUnitsPerSecond *
            Time.deltaTime;
        }
        transform.position = position;
        //ClampInScreen();
        // on space bar, create explosion at teddy bear and destroy teddy bear
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabExplosion, transform.position,Quaternion.identity);
           // Destroy(gameObject);
        }
       


    }
}
