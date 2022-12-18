using UnityEngine;
public class AnimationEventFootSound : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip FootSound;
    
    public void PlayFootSound()
    {
        audioSource.PlayOneShot(FootSound);
    }
}
