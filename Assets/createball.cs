﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createball : MonoBehaviour
{

    public List<GameObject> obj = new List<GameObject>();
    //public List<UISlider> slider = new List<UISlider>();
    //public List<UILabel> lible = new List<UILabel>();
   
    public  int count;
    public static createball callball;
    // Use this for initialization
    void Awake()
    {
        callball = this;
    }
    void Start()
    {
       
        count = 0;
        //随机小球
        //for(int i = 0; i < 10;i++)
        //{
        //    float x = Random.Range(10f,-25f);
        //    Instantiate(obj[i], new Vector3(x,transform.position.y,transform.position.z), Quaternion.identity);
        //}
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
        
    }
    public void Boolsec2()
    {
        obj[1].SetActive(true);
        obj[6].SetActive(true);
        
    }
    public void Boolsec3()
    {
        obj[2].SetActive(true);
        obj[7].SetActive(true);
       
    }
    public void Boolsec4()
    {
        obj[3].SetActive(true);
        obj[8].SetActive(true);
        
    }
    public void Boolsec5()
    {
        obj[4].SetActive(true);
        obj[9].SetActive(true);
        
    }



    // Update is called once per frame
    void Update()
    {

    }
}
