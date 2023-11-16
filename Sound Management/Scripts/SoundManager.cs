using UnityEngine;

public static class SoundManager
{
    //References
    public static GameObject MainCamera;
    public static AudioSource NewAudioSource;


    // PlaySound method to play a given AudioClip
    public static void PlaySound( AudioClip SoundToPlay)
    {
        MainCamera = Camera.main.gameObject;

        // Check if there is no existing AudioSource, create one and attach it to the main camera
        if (NewAudioSource == null)
        {
            NewAudioSource = MainCamera.AddComponent<AudioSource>();
        }

        // Play the given sound using PlayOneShot
        NewAudioSource.PlayOneShot(SoundToPlay);
    }
}
