using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    private int touchCount = 0;
    [SerializeField] private Text touchCountText;
    private void OnMouseDown()
    {
        touchCount++;
        touchCountText.text = touchCount.ToString(); 
        Debug.Log("Clicked");
    }
}
