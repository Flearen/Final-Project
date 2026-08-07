using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{

    [SerializeField] private Animator checkpoint1; 
    private void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Player")){
        checkpoint1.SetBool("triggered", true);
    }

    }
}
