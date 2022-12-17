using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TitleChangeStart : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    public void PressStart()
    {
        //audioSource.PlayOneShot(sound1);
        if (!firstPush)
        {
            audioSource.PlayOneShot(sound1);
            Initiate.Fade("prologue", Color.black, 1.0f);
            firstPush = true;
        }
    }

}
