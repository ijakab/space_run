using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject health;

    public double timeBetweenSpawn = 1.25;
    public double speedingRate = 0.03;
    private double timeToSpawn;
    public double minTimeBetweenSpawn = 0.6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToSpawn <= 0)
        {
            spawn();
            timeToSpawn = timeBetweenSpawn;
            
            if (timeBetweenSpawn > minTimeBetweenSpawn)
            {
                timeBetweenSpawn -= speedingRate;
            }
        }
        else
        {
            timeToSpawn -= Time.deltaTime;
        }
    }

    void spawn()
    {
        int[] positions = getRandomPositions();
        Debug.Log(positions);
        foreach(int offset in positions)
        {
            Vector2 newItemPosition = new Vector2(transform.position.x, transform.position.y + offset);
            instantiateRandomItem(newItemPosition);
        }
    }

    int[] getRandomPositions()
    {
        int[][] combinations = {
            new int[] { 0, 3 },
            new int[] { 0, -3 },
            new int[] { 3, -3 }
        };
        int rand = Random.Range(0, combinations.Length);
        return combinations[rand];
    }

    void instantiateRandomItem(Vector2 position)
    {
        if (Random.Range(0, 100) < 5)
        {
            Instantiate(health, position, Quaternion.identity);
        } else
        {
            Instantiate(obstacle, position, Quaternion.identity);
        }
        
    }
}
