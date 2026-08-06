using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] PatrolPoints;

    public float speedy;
    public int patrolDestination;

    public Transform player;
    public bool isChasing;
    public float chaseDistance;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            if (transform.position.x > player.transform.position.x)
            {
                transform.position += Vector3.left * speedy * Time.deltaTime;
            }
             if (transform.position.x < player.transform.position.x)
            {
                transform.position += Vector3.right * speedy * Time.deltaTime;
            }
            
        }
        else
        {
            if (Vector2.Distance(transform.position, player.transform.position)< chaseDistance)
            {
                isChasing = true;    
            }


            if (patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[0].position, speedy * Time.deltaTime);
                if ( Vector2.Distance(transform.position, PatrolPoints[0].position)< 0.2f)
                {
                    transform.localScale = new Vector3(-2,2,1);
                    patrolDestination = 1;
                }   
            }
            if (patrolDestination == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[1].position, speedy * Time.deltaTime);
                if ( Vector2.Distance(transform.position, PatrolPoints[1].position)< 0.2f)
                {
                    transform.localScale = new Vector3(2,2,1);
                    patrolDestination = 0;
                }
            }
        }




        
    }
}
