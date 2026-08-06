using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLifetime : MonoBehaviour
{
    public float lifeTime = 3f;

    public float damage = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit");
            other.gameObject.GetComponent<enemyHP>().getDamaged(1f);
        }
                
        Destroy(gameObject);
        
    }*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<enemyHP>().getDamaged(1);
            Destroy(gameObject);
        }
    }
}
