using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject inset;
    private float timer;

    public Transform t1;
    public Transform t2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2.0f)
        {
            timer = 0;
            float xRandom = Random.Range(t1.transform.position.x, t2.transform.position.x);
            Instantiate(inset, new Vector3(xRandom, t1.position.y, 0), Quaternion.Euler(0, 0, 0));
        }
    }
}
