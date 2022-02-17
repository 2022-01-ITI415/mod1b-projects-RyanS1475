using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedVertical : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 1f;
    public float topEdge = 6f;
    public float bottomEdge = 2f;

    public float timeValue = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue <= 0)
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
            transform.position = pos;

            if (pos.y > topEdge)
            {
                speed = -Mathf.Abs(speed);
                timeValue = 3;
            }
            else if (pos.y < bottomEdge)
            {
                speed = Mathf.Abs(speed);
                timeValue = 3;
            }
        } else if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
    }
}