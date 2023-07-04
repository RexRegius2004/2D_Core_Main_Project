using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool speed, health;
    public int speedboost, healthboost, duration;
    public PlayerMovement player;
    private int baseMovespeed;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (speed)
        {
            player.moveSpeed += speedboost;
            StartCoroutine(BackToBaseSpeed());

        }
        if (health)
        {
            player.healthpoints += healthboost;
        }
    }
    IEnumerator BackToBaseSpeed()
    {
        yield return new WaitForSeconds(duration);
        player.moveSpeed= baseMovespeed;
    }
    void Start()
    {
        baseMovespeed = player.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
