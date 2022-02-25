using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{
    static public int crntTime = 00;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("BestTime"))
        {
            crntTime = PlayerPrefs.GetInt("BestTime");
        }
        PlayerPrefs.SetInt("BestTime", crntTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Best Time: " + crntTime;
        if (crntTime > PlayerPrefs.GetInt("BestTime"))
        {
            PlayerPrefs.SetInt("BestTime", crntTime);
        }
    }
}
