using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineBehaviour : MonoBehaviour
{
    public float lifeTime = 3f;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime); 
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, rot );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHP>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
