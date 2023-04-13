using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{

    private Animator elevatorAnim;
    public int moving = 0;

    // Start is called before the first frame update
    void Start()
    {
        elevatorAnim = this.transform.parent.GetComponent<Animator>();
        elevatorAnim.SetBool("doorsOpen", true);
    }

    // Update is called once per frame
    void Update()
    {
        //elevatorAnim.SetInteger("MoveDirection", moving);
    }

    private void OnTriggerEnter(Collider other)
    {
        elevatorAnim.SetBool("doorsOpen", false);
        elevatorAnim.SetInteger("MoveDirection", 1);
    }
}
