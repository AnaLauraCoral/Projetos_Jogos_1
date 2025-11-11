using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinSound;
    public AudioClip jumpSoud;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySFX(AudioClip sfx )
    {
        audioSource.PlayOneShot( sfx );

    }



}
