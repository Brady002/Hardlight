using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShield : MonoBehaviour
{

    [Header("Unity Setup")]
    [SerializeField] private InputActionReference shieldButton;
    AudioSource source;
    public GameObject circle;
    public Collider shield;
    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        shield.enabled = false;
        circle.SetActive(false);
        isOn = false;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {
        shieldButton.action.performed += ActivateShield;
        
    }

    private void OnDisable() {
        shieldButton.action.performed -= ActivateShield;
    } 

    public void ActivateShield(InputAction.CallbackContext obj)
    {
        source.Play();
        if (isOn)
        {
            shield.enabled = false;
            circle.SetActive(false);
            source.Stop();
            isOn = false;
        } else if (!isOn)
        {
            shield.enabled = true;
            circle.SetActive(true);
            source.Play();
            isOn = true;
        }
    }
}
