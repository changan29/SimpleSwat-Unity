using UnityEngine;
using System.Collections;
using System;

public class enemyController : MonoBehaviour {

    // Use this for initialization


    private Vector3 enemyPosition = Vector3.zero;
    private Quaternion enemyRotation = Quaternion.Euler(270,90,0);
    public GameObject[] gameObjectArray;
    public GameObject player;
    private System.Random random = new System.Random();
    private Vector3 targetPosition = new Vector3(-22,0,50);
    private int frequence = 0;
    private int index = 0;
    private int shipNum;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        frequence++;
        if(frequence%150 == 0 && shipNum < 10)
        {
            if (Vector3.Distance(player.transform.position, targetPosition) <= 10)
            {
                generate();
            }
            
        }

    }
    public void Decrease()
    {
        shipNum--;
    }


    public void generate()
    {
        shipNum++;
        enemyPosition.x = random.Next((int)player.transform.position.x - 20, (int)player.transform.position.x + 20);
        enemyPosition.z = random.Next((int)player.transform.position.z - 20, (int)player.transform.position.z + 20);
        enemyPosition.y = 2;
        index = random.Next(0, 4);
        Instantiate(gameObjectArray[index], enemyPosition,enemyRotation);
    }
}
