using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour {

    public int Cu_Points = 0;
    private Text txt;

    void Start () {
        txt = GetComponent<Text>();
    }

    void Update () {
        txt.text = "Points = " + Cu_Points;
    }

    public void editPoints(int TempA)
    {
        Cu_Points += TempA;
    }
}
