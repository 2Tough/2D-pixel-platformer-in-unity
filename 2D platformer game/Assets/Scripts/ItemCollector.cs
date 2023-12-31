using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwis = 0;
    [SerializeField] private Text kiwiText;
    [SerializeField] private AudioSource collectSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            collectSFX.Play();
            Destroy(collision.gameObject);
            kiwis++;
            kiwiText.text = "Kiwis: " + kiwis;
        }
    }
}
