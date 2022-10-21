using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator doorAnim;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnim.SetBool("IsOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("IsOpening", false);
    }
}
