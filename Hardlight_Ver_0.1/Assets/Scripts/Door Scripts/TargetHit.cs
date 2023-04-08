using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{

    private GameObject target;
    private Animator targetAnim;
    // Start is called before the first frame update
    void Start()
    {
        //targetAnim = lockedDoor.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy();
        //doorAnim.SetBool("IsOpening", true);
    }

}
