using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] PatrolPoints;

    public float speedy;
    public int patrolDestination;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
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
