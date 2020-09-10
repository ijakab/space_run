using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorEffect : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = player.GetComponent<Player>().transform.position;
        transform.position = new Vector2(playerPosition.x - 1, playerPosition.y);
    }
}
