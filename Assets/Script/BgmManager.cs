using System.Collections;
using UnityEngine;

public class BgmManager : MonoBehaviour {

    private AudioSource bgmAudio;
    public AudioClip stage1;

    public static BgmManager instance;
    void Awake()
    {
        bgmAudio = gameObject.AddComponent<AudioSource>();
        bgmAudio.playOnAwake = false;
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void BgmPlay(string audioName)
    {
        if (string.Equals(audioName, "stage1"))
        {
            bgmAudio.clip = stage1;
            bgmAudio.loop = false;
            bgmAudio.volume = 1.0f;
            bgmAudio.Play();
        }
    }
}

