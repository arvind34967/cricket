using UnityEngine;

public class BatsmanController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 3f;
    
    private Animator animator;
    private Vector3 moveInput;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        HandleMovement();
        HandleShot();
    }
    
    void HandleMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        moveInput = new Vector3(h, 0, v).normalized;
        
        if (moveInput.magnitude > 0)
        {
            transform.Translate(moveInput * moveSpeed * Time.deltaTime);
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
    
    void HandleShot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("PlayShot");
            ExecuteShot();
        }
    }
    
    void ExecuteShot()
    {
        BallPhysics ball = FindObjectOfType<BallPhysics>();
        Vector3 shotDirection = transform.forward;
        ball.HitBall(shotDirection, Random.Range(30f, 60f));
    }
}