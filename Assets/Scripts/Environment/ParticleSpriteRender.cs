﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleSpriteRender : MonoBehaviour {

	public bool followPlayer = true;
	public string sortingLayerName = "Character";
	public int sortingOrder = -1;
	private GameObject playerObj;
	// Use this for initialization
	void Start () {
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayerName;
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingOrder = sortingOrder;
		playerObj = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		//we want the system to follow the player, 
		//but we don't parent it because we don't want rotation mimicked
		if (followPlayer)
			transform.position = playerObj.transform.position;
	}
}
