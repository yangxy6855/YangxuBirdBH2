using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
public class YangxyButton : MonoBehaviour{
	
	public RectTransform rectTransform;
	private Tweener tweener;
	private bool flag =true;
	private void Start(){
		//把rect的位置移动当前的位置
		tweener = rectTransform.DOLocalMove(new Vector3(0,0,0),1);
		tweener.SetAutoKill(false);
		tweener.Pause();
	}

	public void OnClick(){
		if (flag){
			rectTransform.DOPlayForward();
			flag = false;
		}
		else{
			rectTransform.DOPlayBackwards();
			flag = true;
		}
	}
}
