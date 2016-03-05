using UnityEngine;
using System.Collections;

public class flashMuzzle : MonoBehaviour {
    public Material[] mats;
    public float flashTime = 0.1f;
    private float flashTimer = 0;
    private int index = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Flash();
        }
        if (GetComponent<Renderer>().enabled)
        {
            flashTimer += Time.deltaTime;
            if(flashTimer > flashTime)
            {
                GetComponent<Renderer>().enabled = false;
            }
        }
	}
    public void Flash()
    {
        index++;
        index %= 4;
        GetComponent<Renderer>().enabled = true;
        GetComponent<Renderer>().material = mats[index];
        flashTimer = 0;
    }
}
