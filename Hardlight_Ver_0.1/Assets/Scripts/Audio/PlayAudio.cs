using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    AudioSource source;
    private bool played = false;
    public float delay = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !played)
        {
            StartCoroutine(StartAudio());
            played = true;
        }
            

    }

    private IEnumerator StartAudio()
    {
        yield return new WaitForSeconds(delay);
        source.Play();
    }
}
