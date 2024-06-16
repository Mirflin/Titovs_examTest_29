using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

public class PoPUPWindow : MonoBehaviour
{
    public GameObject Window;
    
    
    private void OnMouseEnter()
    {
        Window.SetActive(true);
    }
    private void OnMouseExit()
    {
        Window.SetActive(false);
    }
}
