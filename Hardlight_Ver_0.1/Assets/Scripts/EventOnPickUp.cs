using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnPickUp : MonoBehaviour
{
    public GameObject lockedDoor;
    private Animator doorAnim; 
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = lockedDoor.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy();
        doorAnim.SetBool("IsOpening", true);
    }
}
