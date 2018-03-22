using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGridYpos : MonoBehaviour {
    public RectTransform rect;

	void OnEnable ()
    {
        StartCoroutine(FixPosY());   
	}

    IEnumerator FixPosY()
    {
        yield return new WaitForSeconds(0.1f);
        rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, (rect.sizeDelta.y / 2) * -1);
    }
}
