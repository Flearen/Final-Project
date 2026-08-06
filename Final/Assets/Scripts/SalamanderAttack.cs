using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalamanderAttack : MonoBehaviour
{
    public int damage;
    public PlayerHP playerHP;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHP.TakeDamage(damage);
            
        }
    }
}
