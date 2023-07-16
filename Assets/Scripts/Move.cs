using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Text pontos;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -2.25f, 0);
    }

    private void OnCollisionEnter2D(Collision col)
    {
        score++;
        pontos.text = "Pontos: " + score;
    }
}
