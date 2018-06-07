using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PinCounter : MonoBehaviour
{
    public int Counter;
    public Text text;
    int count;
    // Update is called once per frame
    void Update()
    {
        text.text = Counter.ToString();
        count = 0;
    }
}