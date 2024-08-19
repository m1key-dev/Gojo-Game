using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textObject : MonoBehaviour
{
    public GameObject TextObj;
	float TmStart;
	float TmLen=14f;

	// Use this for initialization
	void Start () {
		TmStart=Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>TmStart + TmLen) 
		{

			TextObj.SetActive (true);
		}
	}
}
