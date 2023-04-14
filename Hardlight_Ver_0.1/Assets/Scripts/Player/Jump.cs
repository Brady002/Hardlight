using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpButton;
    private float jumpHeight = 2f;
    private Rigidbody rb;
    private GravityBody gb;


    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() => jumpButton.action.performed += Jumping;

    private void OnDisable() => jumpButton.action.performed -= Jumping;

    private void Jumping(InputAction.CallbackContext obj)
    {
        rb.AddForce(Vector3.down * -5f * jumpHeight, ForceMode.Impulse);
    }
}
