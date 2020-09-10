using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockerLauncher : MonoBehaviour
{
    public GameObject missile;
    public Text statusDisplay;

    public float refreshTime = 15;
    private float timeToRefresh = 0;
    private bool rocketAvailable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) fire();
        if (timeToRefresh <= 0)
        {
            rocketAvailable = true;
            timeToRefresh = refreshTime;
        }
        else
        {
            timeToRefresh -= Time.deltaTime;
        }
        updateStatus();
    }

    void fire()
    {
        if(rocketAvailable)
        {
            Instantiate(missile, transform.position, Quaternion.identity);
            rocketAvailable = false;
            timeToRefresh = refreshTime;
        }
    }

    void updateStatus()
    {
        if(rocketAvailable)
        {
            statusDisplay.text = "Rocket available!!!";
        } else
        {
            statusDisplay.text = "Rocket available in " + ((int)System.Math.Round(timeToRefresh, 0)).ToString();
        }
    }
}
