using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 position = new Vector2(0, 0);
    public float speed = 70;
    public float distance = 3.5f;

    public float maxH = 5;
    public float minH = -5;

    public int health = 3;
    public Text hpDisplay;
    public GameObject moveSoundEffect;
    public GameObject oldMoveSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(-3, -0.7f);
        moveSound();
    }

    // Update is called once per frame
    void Update()
    {
        hpDisplay.text = health.ToString();
        if (playerLost()) lose();
        else {
            move();
            
        }
    }

    void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, position, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveSound();
            position = new Vector2(transform.position.x, transform.position.y + distance);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveSound();
            position = new Vector2(transform.position.x, transform.position.y - distance);
        }
    }

    void lose()
    {
        SceneManager.LoadScene(1);
    }

    bool playerLost()
    {
        if (transform.position.y < minH) return true;
        if (transform.position.y > maxH) return true;
        if (health < 1) return true;
        return false;
    }

    public void takeDamage()
    {
        health--;
    }

    public void heal()
    {
        health++;
    }

    private void moveSound()
    {
        if (oldMoveSoundEffect != null) Destroy(oldMoveSoundEffect, 0);
        GameObject newInstance = Instantiate(moveSoundEffect, transform.position, Quaternion.identity);
        oldMoveSoundEffect = newInstance;
    }

}