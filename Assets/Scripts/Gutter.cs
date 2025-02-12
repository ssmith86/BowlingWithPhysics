using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        // get the rigidbody of the ball and store it in a local variable ballRigidBody
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        // store velocity magnitude before resetting velocity
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

        // reset the linear and angular velocities
        ballRigidBody.linearVelocity = Vector3.zero;
        ballRigidBody.angularVelocity = Vector3.zero;

        // add force in the forward direction of the gutter
        ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);
    }
}