using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;
    public int time;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

    void Update()
    {
        time++;
        if(time < 300)
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
