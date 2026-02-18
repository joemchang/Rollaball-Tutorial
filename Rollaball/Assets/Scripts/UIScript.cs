using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
	public GameObject ballObj;
	public Slider sliderObj;
	public TMP_Dropdown dropdownObj;
	
	public void HideBall(){
	ballObj.SetActive(false);
	}
	public void ShowBall(){
			ballObj.SetActive(true);
	}
   public void ScaleBall(){
		float scaleVal = sliderObj.value + 1f;
	   ballObj.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
   }
   
   public void ShowDropdownValue(){
		Debug.Log(dropdownObj.value);
}
}

