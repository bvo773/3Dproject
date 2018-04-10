﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {
    // public SpriteRenderer canonRenderer; // Canon's image

	// Use this for initialization
	void Start () {
        // canonRenderer = GetComponent<SpriteRender>();
	}

    // Method: Collect canon parts if the player collide with the part
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            CanonPanel.instance.CollectCanon();
            Destroy(gameObject);
        }
    }

}