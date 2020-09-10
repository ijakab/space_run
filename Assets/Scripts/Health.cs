using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject dieEffect;
    public GameObject dieSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().heal();
            Instantiate(dieEffect, transform.position, Quaternion.identity);
            Instantiate(dieSoundEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
