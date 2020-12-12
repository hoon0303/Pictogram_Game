using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {

    public float jumpForce;     // 점프 힘
    public bool touchOn;

    private bool isJumping;
    private Touch tempTouchs;
    private Vector3 touchedPos;

    private Transform _transform;
    private Rigidbody2D rigdbody;

    private bool rightMoveable;

    void Awake()
    {
        
    } 
    // Use this for initialization
    void Start () {
        _transform = GetComponent<Transform>();
        rigdbody = GetComponent<Rigidbody2D>();
        isJumping = true;
        rightMoveable = true;
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if(rightMoveable && _transform.position.x < -1.7)
        {
            StartCoroutine(rightMoveableCycle());
            Debug.Log("z");
            _transform.Translate(Vector2.right * 1f * Time.deltaTime);
        }*/

        if (_transform.position.x < -1.3)
        {
            _transform.Translate(Vector2.right * 1.2f * Time.deltaTime);
        }

        touchOn = false;
        if (Input.touchCount > 0)  // 터치가 1개 이상이면
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (EventSystem.current.IsPointerOverGameObject(i) == false)
                {
                    tempTouchs = Input.GetTouch(i);
                    if (tempTouchs.phase == TouchPhase.Began) // 해당 터치가 시자되었다면
                    {
                        touchedPos = Camera.main.ScreenToWorldPoint(tempTouchs.position); // get world position
                        Debug.Log(touchedPos);
                        touchOn = true;
                        break;
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (touchOn)
            Jump();
    }
    public void Jump()
    {
        if (isJumping == false || rigdbody.velocity != Vector2.zero)
            return;

        //Debug.Log("Player Jump");
        SoundManager.instance.SoundPlay("jump");
        //rigdbody.AddForce(Vector2.up * jumpForce);
        rigdbody.velocity = Vector2.up * jumpForce;
    }

    /*
    IEnumerator rightMoveableCycle()
    {
        rightMoveable = false;
        yield return new WaitForSeconds(GameManager.instance.FPS);
        rightMoveable = true;
    }*/
}