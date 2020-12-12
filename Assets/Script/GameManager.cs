using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour {

    //private GameObject player;

    public static GameManager instance;
    public float FPS = 1f / 60f;

    void Awake()
    {
        Screen.SetResolution(1280, 720, true);
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization

    void Start()
    {
        InitGame();
        //player = GameObject.FindWithTag("Player");
        //Invoke("StartGame", 3f);
    }
	void Update ()
    {
        
	}

    //물리 관련 움직임 처리
    void FixedUpdate()
    {
       
    }

    /*--------------------*/

    private void InitGame()
    {
        BgmManager.instance.BgmPlay("stage1");

        // 3, 2, 1 뜨고 시작
        StartGame();
    }
    // 게임 시작
    private void StartGame()
    {

    }
}
