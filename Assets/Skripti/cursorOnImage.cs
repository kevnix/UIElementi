using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorOnImage : MonoBehaviour {
    public AudioSource source;
    public AudioClip clip;
    public void onImage()
    {
        source.PlayOneShot(clip);
    }

    public void offImage()
    {
        source.Stop();
    }
}
