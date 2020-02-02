using UnityEngine;

public class Ball : MonoBehaviour {

    //config parameters
    [SerializeField] Paddle paddle1;
    [SerializeField] float ballAngle = 2f;
    [SerializeField] float ballSpeed = 15f;
    [SerializeField] float randomFactor = 0.2f;

    //cached component references 
    Rigidbody2D myRigidBody;

    //state
    Vector2 paddleToBallVector;
    bool hasStarted = false;


    // Use this for initialization
    void Start () {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myRigidBody = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (hasStarted == false) {
            LockBallToPaddle();
            LaunchBallOnMouseClick();
        }


    }

    private void LaunchBallOnMouseClick()
    {
        Vector2 velocityTweak = new Vector2(Random.Range(0f,randomFactor),Random.Range(0f,randomFactor));
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            myRigidBody.velocity = new Vector2(ballAngle, ballSpeed);
            myRigidBody.velocity += velocityTweak;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
        
    }
}
