using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class UINavigator : MonoBehaviour
{
    private GameObject[] buttons;

    private void Awake() {
        buttons = GameObject.FindGameObjectsWithTag("Button");
        Debug.Log(buttons.Length);
    }
    void Start()
    {
        buttons[0].GetComponent<Button>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
