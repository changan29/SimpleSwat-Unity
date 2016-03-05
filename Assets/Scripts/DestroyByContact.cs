using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public enemyController con;
    public gameController game;

	void Start ()
	{

        GameObject enemyControllerObject = GameObject.FindWithTag ("enemyController");
        if (enemyControllerObject != null)
            con = enemyControllerObject.GetComponent<enemyController> ();
        else
            Debug.Log ("找不到tag为enemyController的对象");

        if (con == null)
            Debug.Log ("找不到 enemyController 脚本");

        GameObject gameControllerObject = GameObject.FindWithTag("gameController");
        if (gameControllerObject != null)
            game = gameControllerObject.GetComponent<gameController>();
        else
            Debug.Log("找不到tag为GameController的对象");

        if (game == null)
            Debug.Log("找不到 GameController 脚本");

    }

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "bolt")
		{
            con.Decrease();
            game.addScore();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
		
		
	}
}