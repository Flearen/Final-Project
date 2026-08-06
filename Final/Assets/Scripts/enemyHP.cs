using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public float maxHP;
    public float curHP;
    // Start is called before the first frame update
    void Start()
    {
        curHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getDamaged(float amount)
    {
        curHP -= amount;
        if (curHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
