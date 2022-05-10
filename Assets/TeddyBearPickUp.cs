using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBearPickUp : MonoBehaviour
{
    public GameObject prefabPickup;
    bool collecting = false;
    #region Fields
    List<GameObject> pickups = new List<GameObject>();
    #endregion

    #region Properties
    public GameObject TargetPickup
    {
        get { return pickups[0]; }
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // calculate world position of mouse click
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            // create pickup and add to list
            GameObject pickup = Instantiate<GameObject>(prefabPickup);
            pickup.transform.position = worldPosition;
            pickups.Add(pickup);
        }

    }
    public void RemovePickup(GameObject pickup)
    {
        Debug.Log("Picking");
    }
    /*
    void OnMouseDown()
    {
        // ignore mouse clicks if already collecting
        if (!collecting)
        {
            // calculate direction to target pickup and start moving toward it
            targetPickup = tedTheCollector.TargetPickup;
            Vector2 direction = new Vector2(
            targetPickup.transform.position.x - transform.position.x,
            targetPickup.transform.position.y - transform.position.y);
            direction.Normalize();
            rigidbody2D.AddForce(direction * ImpulseForceMagnitude,
            ForceMode2D.Impulse);
            collecting = true;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // only respond if the collision is with the target pickup
        if (other.gameObject == targetPickup)
        {
            // remove collected pickup from game and go to the next one
            Arrays and Collection Classes 205
        tedTheCollector.RemovePickup(targetPickup);
            rigidbody2D.velocity = Vector2.zero;
            GoToNextPickup();
        }
    }*/
}
