using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    Vector3 zAxisDirection;
    Rigidbody ballRB;
    float pushingForce;
    public Button launchButton;

    void Start()
    {
        ballRB = ball.GetComponent<Rigidbody>();
        zAxisDirection = Vector3.forward; //

        pushingForce = 1000; // 1KN?

        launchButton.onClick.AddListener(MoveBallOption2);
    }

    public void MoveBallOption1()
    {
        // the ball is moving forward for 10 units(meters?) per second
        ballRB.velocity = new Vector3(0, 0, 10);
    }

    public void MoveBallOption2()
    {
        // apply force to ball at rest
        print("Applied Force: "+ pushingForce);
        ballRB.AddForce(pushingForce * zAxisDirection, ForceMode.Force);
        //ballRB.AddForce(appliedForce * zAxisDirection, ForceMode.Acceleration);
        //ballRB.AddForce(appliedForce * zAxisDirection, ForceMode.Impulse);
        //ballRB.AddForce(appliedForce * zAxisDirection, ForceMode.VelocityChange);
    }
}
