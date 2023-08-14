using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Finish")
        {
            Debug.Log("It works");
            finishSound.Play();
            //CompleteLevel();
        }
    }

    //private void CompleteLevel()
    //{
        
    //}

}
