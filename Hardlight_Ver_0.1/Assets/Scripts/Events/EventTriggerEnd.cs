using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerEnd : MonoBehaviour
{
    private bool hasBeenTriggered = false;
    public GameObject[] lights;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!hasBeenTriggered)
        {
            StartCoroutine(Flicker());
            hasBeenTriggered = true;
        }
        
        
    }

    private IEnumerator Flicker()
    {
        for (int l = 0; l < lights.Length; l++)
        {
            lights[l].active = false;
        }
        yield return new WaitForSeconds(0.1f);
        for (int l = 0; l < lights.Length; l++)
        {
            lights[l].active = true;
        }
        yield return new WaitForSeconds(0.05f);
        for (int l = 0; l < lights.Length; l++)
        {
            lights[l].active = false;
        }
        yield return new WaitForSeconds(0.05f);
        for (int l = 0; l < lights.Length; l++)
        {
            lights[l].active = true;
        }
        yield return new WaitForSeconds(0.3f);
        for (int l = 0; l < lights.Length; l++)
        {
            lights[l].active = false;
            //lights[l].
        }
        yield return new WaitForSeconds(4f);
        lights[2].active = true;
        yield return new WaitForSeconds(.1f);
        lights[2].active = false;
        yield return new WaitForSeconds(.1f);
        lights[2].active = true;
    }
}
