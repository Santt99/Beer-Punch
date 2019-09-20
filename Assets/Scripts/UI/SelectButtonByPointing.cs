using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;//
public class SelectButtonByPointing : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter (PointerEventData eventData) 
	{
		
        this.GetComponent<Button>().Select();
	}
}
