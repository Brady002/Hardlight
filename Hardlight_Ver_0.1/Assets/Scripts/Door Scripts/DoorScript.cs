using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator doorAnim;
    public bool locked = false;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(!locked)
        {
            doorAnim.SetBool("IsOpening", true);
            source.Play();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(!locked)
        {
            doorAnim.SetBool("IsOpening", false);
            source.Play();
        }
        
    }
}
