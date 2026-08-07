using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    private string currentSceneName;

    public int maxhp ;

    public int currenthp;

    private int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        string currentSceneName = SceneManager.GetActiveScene().name;

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
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
            
            currenthp = maxhp;
            
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
