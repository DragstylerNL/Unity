using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpScript : MonoBehaviour {

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public Sprite sprite14;
    public Sprite sprite15;
    public Sprite sprite16;
    public Sprite sprite17;
    public Sprite sprite18;
    public Sprite sprite19;
    public Sprite sprite20;

    public int Cu_Health = 10;
    private Text txt;
    public GameObject BarHP;

    private Image cp;
    private Sprite[] Sprites;

    public Slider SliderHP;
    private Slider sl;

    void Start()
    {
        txt = GetComponent<Text>();
        cp = BarHP.GetComponent<Image>();
        sl = SliderHP.GetComponent<Slider>();
        print(cp);
        editPoints(0);
    }

    void Update()
    {
        txt.text = "Current HP: " + Cu_Health + "/20";
    }

    public void editPoints(int TempA)
    {
        if((Cu_Health>=20 && TempA==1) || (Cu_Health <= 0 && TempA == -1)) { }
        else {Cu_Health += TempA;}
        sl.value = Cu_Health;
        
        switch (Cu_Health){
            case 0:
                cp.sprite = sprite0;
                break;
            case 1:
                cp.sprite = sprite1;
                break;
            case 2:
                cp.sprite = sprite2;
                break;
            case 3:
                cp.sprite = sprite3;
                break;
            case 4:
                cp.sprite = sprite4;
                break;
            case 5:
                cp.sprite = sprite5;
                break;
            case 6:
                cp.sprite = sprite6;
                break;
            case 7:
                cp.sprite = sprite7;
                break;
            case 8:
                cp.sprite = sprite8;
                break;
            case 9:
                cp.sprite = sprite9;
                break;
            case 10:
                cp.sprite = sprite10;
                break;
            case 11:
                cp.sprite = sprite11;
                break;
            case 12:
                cp.sprite = sprite12;
                break;
            case 13:
                cp.sprite = sprite13;
                break;
            case 14:
                cp.sprite = sprite14;
                break;
            case 15:
                cp.sprite = sprite15;
                break;
            case 16:
                cp.sprite = sprite16;
                break;
            case 17:
                cp.sprite = sprite17;
                break;
            case 18:
                cp.sprite = sprite18;
                break;
            case 19:
                cp.sprite = sprite19;
                break;
            case 20:
                cp.sprite = sprite20;
                break;
        }

    }
}
