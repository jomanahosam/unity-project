using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	Transform Player;
	UnityEngine.AI.NavMeshAgent nav;
     
	// Use this for initialization
	void Awake () 
	{
		Player = GameObject.FindWithTag ("Player").transform; 
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		nav.SetDestination (Player.position);
		
	}
}
