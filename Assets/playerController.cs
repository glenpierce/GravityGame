using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public GameObject planet;
    public float gravityConstant;
    public float initialVelocity; //between 175-176
    public float distanceFromSurface;
    public float velocity;

    void Start() {
        Vector3 initalForceVector = new Vector3(0, 1, 0) * initialVelocity;
        gameObject.GetComponent<Rigidbody>().AddForce(initalForceVector);
    }

    void Update() {
        float distance = Vector3.Distance(transform.position, planet.transform.position);
        float distanceSquared = distance * distance;
        float forceValue = gravityConstant / distanceSquared;
        Vector3 forceWithDirection = (forceValue*(planet.transform.position - transform.position));
        gameObject.GetComponent<Rigidbody>().AddForce(forceWithDirection);
        distanceFromSurface = distance;
        velocity = gameObject.GetComponent<Rigidbody>().velocity.magnitude;
    }
}
