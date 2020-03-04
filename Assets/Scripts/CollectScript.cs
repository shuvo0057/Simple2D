using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScript : MonoBehaviour
{
  
    public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collider)
    {
        collectSound.Play();
           ScoreScript.theScore += 10;
       
        Destroy(gameObject);



    }

}
