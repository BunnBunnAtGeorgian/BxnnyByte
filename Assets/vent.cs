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
        smoke = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            smoke.Stop();
            soundSource.PlayOneShot(ventSound);
            ScoreManager.AddToScore(2, 10f);
        }
    }

}
