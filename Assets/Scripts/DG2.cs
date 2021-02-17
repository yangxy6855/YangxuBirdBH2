using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DG2 : MonoBehaviour{

	private void Start(){
		var tweenerCore = transform.DOMoveX(5, 5).From();
		tweenerCore.SetEase(Ease.OutBounce);
	}
	
}

	
