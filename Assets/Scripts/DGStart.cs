using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
public class DGStart : MonoBehaviour{

	public Transform cubeTransform;

	public RectTransform rectTransform;

	public Vector3 myValue = new Vector3(0, 0, 0);
	// Use this for initialization	
	void Start (){
		DOTween.To(() => myValue, x => myValue = x, new Vector3(0, 0, 0), 1);
	}

	private void Update(){
		//cubeTransform.position = myValue;
		rectTransform.localPosition = myValue;
	}
}
