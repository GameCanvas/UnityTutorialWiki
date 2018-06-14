using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public Image[] StageClearImage;
    private Rigidbody rigid;
    private object pinCounter;
    private Type PinCounterType;
    void Start()
    {
        var ball = GameObject.Find("Ball");
        if (ball != null)
        {
            rigid = ball.GetComponent<Rigidbody>();
        }
        var pins = GameObject.Find("Pins");
        if (ball != null)
        {
            PinCounterType = Type.GetType("PinCounter");
            if (PinCounterType != null)
            {
                pinCounter = pins.GetComponent(PinCounterType);
            }

        }


    }
    private void Update()
    {
        if (rigid != null && Mathf.Abs(rigid.velocity.x) > 1f)
        {
            StageClear(1);
        }

        if (PinCounterType != null && (int)PinCounterType.GetField("Counter").GetValue(pinCounter) > 1)
        {
            StageClear(2);
        }

    }
    public void StageClear(int index)
    {
        StageClearImage[index - 1].enabled = true;
    }

}
