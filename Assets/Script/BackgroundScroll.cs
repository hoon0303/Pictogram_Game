using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    // 일단 무한 스크롤 방식으로 함
    // x좌표 첫 그림 11.5, 두번 째 그림 50.5 차이 39
    private float scrollSpeed;
    private Transform _transform;
    private Vector3 respawnPos;
    private float intervalPos;

    // Use this for initialization
    void Start()
    {
        intervalPos = -27.5f;
        scrollSpeed = 2f;
        _transform = transform;
        respawnPos = new Vector3(50.5f, 0, 0);
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