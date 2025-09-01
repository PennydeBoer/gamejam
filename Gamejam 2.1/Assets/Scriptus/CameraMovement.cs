using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 oldMouseDirection;
    [SerializeField] private float Sensitivity = 1f;
    [SerializeField] private PlayerObject playerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cameramovement();
    }

    private void Cameramovement()
    {
        // Get mouse X movement
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity;

        // Rotate player on Y axis
        transform.Rotate(Vector3.right * mouseY);


        //// Lock the cursor to the center of the screen and hide it
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

        //// Get mouse movement
        //float mouseX = Input.GetAxis("Mouse X") * Sensitivity;
        //float mouseY = Input.GetAxis("Mouse Y") * Sensitivity;

        //// Rotate camera based on mouse movement
        //// Clamp vertical rotation to prevent flipping
        //Vector3 currentRotation = transform.localEulerAngles;
        //float desiredX = currentRotation.y + mouseX;
        //float desiredY = currentRotation.x - mouseY;

        //// Clamp vertical rotation between -90 and 90 degrees
        //desiredY = Mathf.Clamp(desiredY > 180 ? desiredY - 360 : desiredY, -90f, 90f);

        //transform.localEulerAngles = new Vector3(desiredY, 0, 0f);
    }
}
