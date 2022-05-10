using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    Timer timer;
    float startTime;
    const float CircleLifeSpan = 10;
    Timer deathTimer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Timer>();
        timer.Duration = 3;
        timer.Run();
        startTime = Time.time;

        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = CircleLifeSpan;
        deathTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        // check for timer just finished
        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;
            print("Timer ran for " + elapsedTime + " seconds");
            // save start time and restart timer
            startTime = Time.time;
            timer.Run();
        }

        // kill teddy bear if death timer finished
        if (deathTimer.Finished)
        {
            Destroy(gameObject);
        }



    }
}
