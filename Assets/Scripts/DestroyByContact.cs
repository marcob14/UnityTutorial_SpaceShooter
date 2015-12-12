using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Boundary")
            return;
		 
		Instantiate(explosion, transform.position, transform.rotation);

		if(obj.tag == "Player")
			Instantiate(playerExplosion, obj.transform.position, obj.transform.rotation);

        Destroy(obj.gameObject);
        Destroy(gameObject);
    }
}
