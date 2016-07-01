using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}

    public void StartGames()
    {
        Application.LoadLevel(1);
    }

    public void Onite()
    {
        obj.SetActive(true);
    }
    public void Offite()
    {
        obj.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
