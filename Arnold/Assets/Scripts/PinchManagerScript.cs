using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
    private bool currentlyZooming = false;
    float tempZoom;
    void Update()
    {
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            if (!currentlyZooming)
                tempZoom = 100;
            currentlyZooming = true;
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // If the camera is orthographic...
            
                // ... change the orthographic size based on the change in distance between the touches.
                tempZoom += deltaMagnitudeDiff * orthoZoomSpeed;

            // Make sure the orthographic size never drops below zero.
            tempZoom = Mathf.Clamp(tempZoom, 0.1f, 300f);
            
        }
        else
            currentlyZooming = false;
    }
  
     /*
     *  KAZPER DOCS
     * 
     */
   public float GetRZoom()
    {
        return tempZoom;  //So this gets set to a 100 every time a user starts pinching and
        // gives out a new relative size from there. Capped between (0-300)
    }

   public bool IsZooming()
    {
        return currentlyZooming;    //To know whether the user is currently zooming. You'll want to
        // stop reading getRZoom by the time the user starts a new pinch
    }
}
