using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Boundary")
            return;

        Destroy(obj.gameObject);
        Destroy(gameObject);
    }
}
