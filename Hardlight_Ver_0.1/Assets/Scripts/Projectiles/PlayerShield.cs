using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{

    [Header("Unity Setup")]
    AudioSource source;
    public Collider shield;

    // Start is called before the first frame update
    void Start()
    {
        shield.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RaiseShield()
    {
        shield.enabled = true;
    }

    public void LowerShield()
    {
        shield.enabled = false;
    }
}
