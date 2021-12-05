using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilsClass
{
    public static Camera mainCam;
    public static Vector3 GetMouseWorldPosition()
    {
        if (mainCam == null)
            mainCam = Camera.main;
        
        Vector3 mouseWouldPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mouseWouldPosition.z = 0f;
        return mouseWouldPosition;
    }
}
