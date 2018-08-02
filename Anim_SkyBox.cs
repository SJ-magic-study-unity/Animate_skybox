/************************************************************
参考URL
	http://matudozer.blog.fc2.com/blog-entry-24.html
	
注意
	skybox materialは、
		SkyBox/6sided
************************************************************/
using UnityEngine;
using System.Collections;

public class Anim_SkyBox : MonoBehaviour {
	float curRot = 0f;
	float rotSpeed = 0.5f;


	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		curRot += rotSpeed * Time.deltaTime;
		curRot %= 360f;
		RenderSettings.skybox.SetFloat("_Rotation", curRot);
	}
}
