using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxhp ;

    public int currenthp;
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
            
            Destroy(gameObject);
            // add a respawn enemies line here.
            //temporary destroy(maybe)
            
        }
    }
}
