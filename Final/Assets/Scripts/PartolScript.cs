using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartolScript : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;

    public float speed;

//add animator later

    private Transform currentPoint;

    // Start is called before the first frame update
    void Start()
    {
        flip();
        rb = GetComponent<Rigidbody2D>();
        //add something for getting the animator component
        currentPoint = pointB.transform;
        // animation bool goes here
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if ( currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed , 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed , 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position)< 0.5f && currentPoint == pointB.transform)
        {
            flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position)< 0.5f && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
        }
    }
    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
