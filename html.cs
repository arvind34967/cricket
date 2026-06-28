using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float gravity = 9.81f;
    private Rigidbody rb;
    private Vector3 initialPosition;
    private bool inFlight = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }
    
    public void HitBall(Vector3 direction, float power)
    {
        if (inFlight) return;
        
        inFlight = true;
        Vector3 velocity = direction.normalized * power;
        velocity.y = power * 0.6f; // arc angle
        
        rb.velocity = velocity;
        rb.isKinematic = false;
        
        GameManager.Instance.OnBallBowled();
    }
    
    public void ResetPosition()
    {
        inFlight = false;
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        transform.position = initialPosition;
    }
    
    void FixedUpdate()
    {
        if (inFlight && rb.velocity.magnitude < 0.5f)
        {
            inFlight = false;
        }
    }
}