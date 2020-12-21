using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCOllector : MonoBehaviour
{
	
	private bool mFloorTouched = false;
	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = true;
		}
	}

	void OnCollisionExit(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("Coin")) {
			Destroy(other.gameObject);
		}
	}
}
