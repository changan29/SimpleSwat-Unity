using UnityEngine;
using System.Collections;

public class shipMover : MonoBehaviour
{
    public float speed = -10;
    public GameObject enemayBolt;
    public GameObject player;
    private int time;
    private Quaternion enemyBoltRotation = Quaternion.Euler(180, 0, 0);
    void Start()
    {
        GetComponent<Rigidbody>().velocity = player.transform.forward * speed;
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = player.transform.forward * speed;
        time++;
        //attack();
        if (time%50 == 0)
        {
            Instantiate(enemayBolt, transform.position,enemyBoltRotation);
            GetComponent<AudioSource>().Play();
            
        }
        if(time >= 300)
        {
            Destroy(gameObject);
        }



    }

    void attack()
    {
        if(Vector3.Distance(this.transform.position,player.transform.position) < 20)
        {
            this.transform.LookAt(player.transform);
        }
    }
}
