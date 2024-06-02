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
        Debug.Log("Trigger enter!");
        Vector3 NewPosition = new Vector3(678,0,-9720);
        Transform Trans = Window.GetComponent<Transform>();
        Trans.position = (new Vector3(Trans.position.x + -600, 0, 0));
    }
    private void OnMouseExit()
    {
        Debug.Log("Trigger exit!");
        Vector3 NewPosition = new Vector3(1225, 0, -9720);
        Window.GetComponent<Transform>().position = NewPosition;
    }
}
