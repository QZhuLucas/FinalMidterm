using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float myCoolTimer = 100;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        myCoolTimer -= Time.deltaTime;
        timerText.text = myCoolTimer.ToString("f2");
        print(myCoolTimer);

    }
}