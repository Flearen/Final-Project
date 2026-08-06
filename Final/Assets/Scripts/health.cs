using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float MaxHP = 10;
    public float currentHP = 10;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    public void TakeDamage(float amt){
        currentHP -= amt;
        if (currentHP <= 0){
            Destroy(gameObject);
        }
    }
}
