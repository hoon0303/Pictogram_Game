using System.Collections;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource mAudio;
    public AudioClip jumpSound;

    public static SoundManager instance;
    void Awake()
    {
        mAudio = gameObject.AddComponent<AudioSource>();
        mAudio.playOnAwake = false;
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void SoundPlay(string audioName)
    {
        if(string.Equals(audioName, "jump"))
        {
            mAudio.PlayOneShot(jumpSound, 0.8f);
        }
    }
}
