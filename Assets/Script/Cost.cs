using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isDelay = false;
    public float delayTime = 2f;
    public int cost = 0;
    public float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(cost < 10 && !isDelay)
            {
                isDelay = true;
                cost++;
            }

            if (isDelay)
            {
                timer += Time.deltaTime;
                if(timer >= delayTime)
                {
                    timer = 0f;
                    isDelay = false;
                }

            }

    }


}
