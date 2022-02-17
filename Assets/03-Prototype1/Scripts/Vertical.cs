using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    [Header("Set in Inspector")]

    public float speed = 1f;
    public float topEdge = 7f;
    public float bottomEdge = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.y > topEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (pos.y < bottomEdge)
        {
            speed = Mathf.Abs(speed);
        }
    }
}
