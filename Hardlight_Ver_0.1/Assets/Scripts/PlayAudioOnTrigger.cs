using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{

    private bool played = false;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        if(source != null)
        {
            source = GetComponent<AudioSource>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
