using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrapBehavior : MonoBehaviour
{
    public Animator anim;
    public int trapDamage;
    public PlayerMovement player;
    public bool isPlayerOnTop;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTop = true;
            if (collision.CompareTag("Player"))
            {
                anim.SetBool("isActive", true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerOnTop= false;
        if (collision.CompareTag("Player"))
        { 
            anim.SetBool("isActive", false); 
        }
       
    }

    public void PlayerDamage()
    {
        player.healthpoints -= trapDamage; 
    }
}
