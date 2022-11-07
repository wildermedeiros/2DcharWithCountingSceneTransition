using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCircleCount : MonoBehaviour
{
    [SerializeField] CircleKeeper circleKeeper = null;
    [SerializeField] TextMeshProUGUI text = null;

    void Update()
    {
        text.text = circleKeeper.GetCircleCount().ToString();
    }
}
