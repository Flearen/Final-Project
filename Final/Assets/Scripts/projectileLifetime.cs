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
}
