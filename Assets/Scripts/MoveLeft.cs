using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5;
    public float distance = 20;
    public string direction = "Left";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = direction == "Left" ? transform.position.x - distance : transform.position.x + distance;
        Vector2 newPosition = new Vector2(newX, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }
}
