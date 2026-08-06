using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private GameObject player;
    private float timer;

    public float health;

    public float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);
        
        if (distance <= 10)
        {
            timer += Time.deltaTime;

            if(timer > 1.1)
            {
              timer = 0;
              shoot();
            }   
        }
        
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
    
    
    /*public void TakeDamage(float amt)
    {
        health -= amt;
        if (health <= 0 )
        {
            Destroy(gameObject);
        }
    }*/
}
