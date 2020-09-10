using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 10;
    public float end = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x <= end)
        {
            float width = GetComponent<RectTransform>().rect.width;
            transform.position = new Vector2(transform.position.x + 2 * width, transform.position.y);
        }
    }
}
