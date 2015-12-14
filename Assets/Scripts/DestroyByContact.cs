using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if (gameControllerObject)
			gameController = gameControllerObject.GetComponent<GameController>();

		if (gameController == null)
			Debug.Log ("Cannot find 'GameController' script");
	}

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Boundary")
            return;
		 
		Instantiate(explosion, transform.position, transform.rotation);

		if (obj.tag == "Player")
			Instantiate (playerExplosion, obj.transform.position, obj.transform.rotation);

		gameController.AddScore (scoreValue);

        Destroy(obj.gameObject);
        Destroy(gameObject);
    }
}
