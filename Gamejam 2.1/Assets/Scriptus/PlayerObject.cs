using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerObject : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private GameObject frogwizzard;
    private Animator anim;
    [SerializeField] private float Speed = 1f;
    [SerializeField] private float JumpForce = 5f;

    [SerializeField] private float Sensitivity = 1f;

    

    private Vector3 MouseDirection;

    public float Health = 100f;
    private int collisionCount = 0;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = frogwizzard.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        CameraMovement();

        if (Input.GetKeyDown(KeyCode.Space) && collisionCount > 0)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        if(Health < 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = (transform.right * moveHorizontal + transform.forward * moveVertical).normalized;
        if (movement != Vector3.zero)
        {
            Debug.Log("Moving");
            anim.Play("Walk");
        }   
        else
        {
            Debug.Log("Idle");
            anim.Play("Idle");
        }
        rb.MovePosition(transform.position + movement * Speed * Time.deltaTime);
    }

    private void CameraMovement()
    {
        // Get mouse X movement
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity;

        // Rotate player on Y axis
        transform.Rotate(Vector3.up * mouseX);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }

    private void OnCollisionExit(Collision collision)
    {
        collisionCount--;
    }
}
