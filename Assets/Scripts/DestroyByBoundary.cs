using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
    
	void OnTriggerExit(Collider obj) {
        Destroy(obj.gameObject);
	}
}
