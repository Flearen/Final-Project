using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVILprojectileLifetime : MonoBehaviour
{
    public float lifeTime = 3f;

    public int damage;

    private GameObject player;
    public PlayerHP playerHP;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime); 
        GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
   
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHP>().TakeDamage(damage);
            
        }
    }
}