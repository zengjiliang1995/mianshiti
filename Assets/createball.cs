using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createball : MonoBehaviour
{

    public List<GameObject> obj = new List<GameObject>();
    //public List<UISlider> slider = new List<UISlider>();
    //public List<UILabel> lible = new List<UILabel>();
    private bool ball1;
    private bool ball2;
    private bool ball3;
    private bool ball4;
    private bool ball5;
    private int count;
    public static createball callball;
    // Use this for initialization
    void Awake()
    {
        callball = this;
    }
    void Start()
    {
        ball1 = false;
        ball2 = false;
        ball3 = false;
        ball4 = false;
        ball5 = false;
        count = 0;
    }

    public void BallAdd()
    {
        Boolsec1();
        if (count == 1)
        {
            Boolsec2();
        }
        if (count == 2)
        {
            Boolsec3();
        }
        if (count == 3)
        {
            Boolsec4();
        }
        if (count == 4)
        {
            Boolsec5();
        }
        count++;
    }

    public void Boolsec1()
    {
        obj[0].SetActive(true);
        obj[5].SetActive(true);
        ball1 = true;
    }
    public void Boolsec2()
    {
        obj[1].SetActive(true);
        obj[6].SetActive(true);
        ball2 = true;
    }
    public void Boolsec3()
    {
        obj[2].SetActive(true);
        obj[7].SetActive(true);
        ball3 = true;
    }
    public void Boolsec4()
    {
        obj[3].SetActive(true);
        obj[8].SetActive(true);
        ball4 = true;
    }
    public void Boolsec5()
    {
        obj[4].SetActive(true);
        obj[9].SetActive(true);
        ball5 = true;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
