using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public int currentAdaptiveLevel;
    public float transitionTime = 3;
    public AudioMixerSnapshot snapshotLevel;
    private bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !played)
        {
            snapshotLevel.TransitionTo(transitionTime);
            played = true;
        }
        

    }

}
