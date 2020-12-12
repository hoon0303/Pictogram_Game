using System.Collections;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public static MapGenerator instance;
    public GameObject[] ground;
    private bool generable;
    private Vector2 initPos;
    private Vector3 initScale;
    private float[] initPosY;
    private GameObject madeObject;
    private int initIndex;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

        initIndex = 0;
        initPosY = new float[4] { -2.7f, -1.4f, -0.2f, -1.4f};
        generable = true;
    }

    // Use this for initialization
    void Start () {
        initPos.x = 16f;
        initScale.y = 1.5f;
        initScale.z = 1f;
    }
	
	// Update is called once per frame
	void Update () {
        GenerateTile();
    }

    private void GenerateTile()
    {
        if(generable)
        {
            StartCoroutine(GenerateCycle());
            initPos.y = initPosY[initIndex++ % 4];
            initScale.x = Random.Range(3.0f, 5.0f);
            madeObject = Instantiate(ground[0], initPos, Quaternion.identity);
            madeObject.transform.localScale = initScale;
        }
    }

    IEnumerator GenerateCycle()
    {
        generable = false;
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        generable = true;
    }
}
