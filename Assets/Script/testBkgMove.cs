using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 임시 맵 스크롤
//47 - 17.85 = 29.15
public class testBkgMove : MonoBehaviour {


    private float scrollSpeed;
    private Transform _transform;
    private Vector3 respawnPos;
    private float intervalPos;
    

    // Use this for initialization
    void Start()
    {
        intervalPos = -17.85f;
        scrollSpeed = 3f;
        _transform = transform;
        respawnPos = new Vector3(29.15f, 0, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if (_transform.position.x < intervalPos)
        {
            _transform.position = respawnPos;
        }
    }
}
