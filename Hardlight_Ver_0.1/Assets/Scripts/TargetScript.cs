using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    private Animator targetAnim;
    public bool locked = false;
    public bool isHit = false;
    //AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        targetAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit == true)
        {
            targetAnim.SetBool("hasBeenHit", true);
            locked = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!locked)
        {
            targetAnim.SetBool("hasBeenHit", true);
            //activated = true;
        }

    }
}
