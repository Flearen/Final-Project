using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int maxhp ;

    public int currenthp;

    private int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
           
    }
    public void TakeDamage(int amount)
    {
       
        currenthp -= amount;
        
        if (currenthp <= 0)
        {
            
            //Destroy(gameObject);
            // add a respawn enemies line here.
            //temporary destroy(maybe)
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spine")
        {
            TakeDamage(damage);
            
        }
    }

}
