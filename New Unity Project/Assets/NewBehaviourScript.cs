using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  transform.Rotate(new Vector3(0f,0.8f,0f)); // y軸を軸として90°回転

	}
}
