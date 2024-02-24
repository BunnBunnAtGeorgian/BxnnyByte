using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vent : MonoBehaviour
{

    // clean the vent
    public AudioClip ventSound;
    public AudioSource soundSource;
    ParticleSystem smoke;
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        smoke = GetComponentInChildren<ParticleSystem>();

        if (obj != null)
        {
            // Get the component by its type
            soundSource = obj.GetComponent<AudioSource>();
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            smoke.Stop();
            if (smoke.isPlaying)
            {
                soundSource.PlayOneShot(ventSound);
                ScoreManager.AddToScore(2, 10f);
            }
        }
    }

}
