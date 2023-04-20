using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEvent : MonoBehaviour
{

    public GameObject sphere;

    private void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(true);

    }
}
