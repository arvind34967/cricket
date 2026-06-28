using UnityEngine;

public class BowlerController : MonoBehaviour
{
    public Transform ballStartPosition;
    public float bowlPower = 40f;
    private BallPhysics ball;
    
    void Start()
    {
        ball = FindObjectOfType<BallPhysics>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BowlBall();
        }
    }
    
    void BowlBall()
    {
        Vector3 bowlDirection = transform.forward;
        // Add slight deviation for variation
        bowlDirection += new Vector3(Random.Range(-0.2f, 0.2f), 0, 0);
        
        ball.transform.position = ballStartPosition.position;
        ball.HitBall(bowlDirection.normalized, bowlPower);
    }
}