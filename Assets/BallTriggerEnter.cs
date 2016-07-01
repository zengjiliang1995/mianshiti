using UnityEngine;
using System.Collections;
using ADBannerView = UnityEngine.iOS.ADBannerView;

public class BallTriggerEnter : MonoBehaviour
{
    public UISlider slider;
    public UILabel lible;
    private float hp = 100;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            hp -= Random.Range(1,21);
        }
    }
	// Update is called once per frame
	void Update () {
        lible.text = hp.ToString();
        slider.value = hp / 100;
    }
}
