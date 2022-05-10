using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject gameObjectPrefab;
    [SerializeField] Sprite pointOne;
    [SerializeField] Sprite pointTwo;
    [SerializeField] Sprite pointThree;

    //spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
    Timer spawnTimer;


    // spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        // save spawn boundaries for efficiency
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        // check for time to spawn a new teddy bear
        if (spawnTimer.Finished)
        {
            SpawnBear();
            // change spawn timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
}

    private void SpawnBear()
    {
        // generate random location and create new teddy bear
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
        Random.Range(minSpawnY, maxSpawnY),
        -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        GameObject teddyBear = Instantiate(gameObjectPrefab) as GameObject;
        teddyBear.transform.position = worldLocation;

        SpriteRenderer spriteRenderer = teddyBear.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = pointOne;
        }
        else if(spriteNumber == 1)
        {
            spriteRenderer.sprite = pointTwo;
        }
        else
        {
            spriteRenderer.sprite = pointThree;
        }


    }
}
