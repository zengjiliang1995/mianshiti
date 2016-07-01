using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateCube : MonoBehaviour
{
    public List<GameObject> obj = new List<GameObject>();
    private int count;
    public List<BoxCollider>boxs=new List<BoxCollider>();
	// Use this for initialization
	void Start ()
	{
	    count = 0;
	    for (int i = 0; i < 50; i++)
	    {
	        obj[Random.Range(0, 79)].SetActive(true);
	    }
    }

    public void AddPane()
    {
        if (count == 0)
        {
            for (int i = 0; i < 66; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
            }
        }
        
        if (count == 1)
        {
            for (int i = 0; i < 79; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
            }
        }
        count++;
    }

    public void CretePane()
    {
        if (count == 0)
        {
            for (int i = 0; i < 30; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
            }
        }
        
        if (count == 1)
        {
            for (int i = 0; i < 50; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
            }

        }
        if (count == 2)
        {
            for (int i = 0; i < 66; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
            }
        }
        if (count == -1)
        {
            for (int i = 0; i < 10; i++)
            {
                obj[Random.Range(0, 78)].SetActive(true);
                count = 0;
            }
            
        }
        for (int i = 0; i < 79; i++)
        {
            obj[Random.Range(0, 78)].SetActive(false);
        }
        count--;
    }

    public void ResultGame()
    {
        Application.LoadLevel(1);
        createball.callball.count = 0;
    }
    public void Planes1()
    {
        obj[0].SetActive(true);
    }
    public void Planes2()
    {
        obj[1].SetActive(true);
    }
    public void Planes3()
    {
        obj[1].SetActive(false);
    }
    public void Planes4()
    {
        obj[0].SetActive(false);
    }
    // Update is called once per frame
    void Update () {
        if (count == 2)
        {
            boxs[0].enabled = false;
        }
        else
        {
            boxs[0].enabled = true;
        }
        if (count == -1)
        {
            boxs[1].enabled = false;
        }
        else
        {
            boxs[1].enabled = true;
        }
	}
}
