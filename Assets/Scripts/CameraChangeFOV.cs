using UnityEngine;

public class CameraChangeFOV : MonoBehaviour
{
    private float defWidth;
    private float defFieldOfView;
    private float fOVFactor;
    private void Start()
    {
        if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            defWidth = Screen.width;
        }
        else { defWidth = Screen.height; }              

        defFieldOfView = gameObject.GetComponent<Camera>().fieldOfView;

    }
    private void Update()
    {
        fOVFactor = Screen.width / defWidth;
        gameObject.GetComponent<Camera>().fieldOfView = defFieldOfView * fOVFactor;        
    }
}
