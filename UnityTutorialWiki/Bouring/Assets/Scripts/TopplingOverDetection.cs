using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopplingOverDetection : MonoBehaviour
{
    public PinCounter pinCounter;
    bool isCounted;
    // Update is called once per frame
    void Update()
    {
        if ((Mathf.Abs(transform.rotation.eulerAngles.x) > 40 || Mathf.Abs(transform.rotation.eulerAngles.z) > 40) && !isCounted)
        {
            pinCounter.Counter = pinCounter.Counter + 1;
            isCounted = true;
        }
    }
}