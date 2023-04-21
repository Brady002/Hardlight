using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public int currentAdaptiveLevel;
    //public AudioMixerSnapshot[] snapshotLevels;
    public float transitionTime = 3;
    public AudioMixerSnapshot snapshotLevel;

    public void AdjustAudioLevel (int level)
    {
        //currentAdaptiveLevel = level;
        //snapshotLevels[currentAdaptiveLevel - 1].TransitionTo(transitionTime);
        //Debug.Log("feje");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        //currentAdaptiveLevel = level;
        snapshotLevel.TransitionTo(transitionTime);
        //Debug.Log("feje");

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
