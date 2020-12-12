using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTileMove : MonoBehaviour {

    private Transform _transform;
    public float speed;
	// Use this for initialization
	void Start () {
        _transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        _transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(_transform.position.x < -8.5)
        {
            Destroy(this.gameObject);
        }
	}
}
