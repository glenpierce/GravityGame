using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public GameObject planet;
    public float gravityConstant;

    void Start() {
        
    }

    void Update() {
        float distance = Vector3.Distance(transform.position, planet.transform.position);
        float distanceSquared = distance * distance;
        float forceValue = gravityConstant / distanceSquared;
        Vector3 forceWithDirection = (forceValue*(planet.transform.position - transform.position));
        gameObject.GetComponent<Rigidbody>().AddForce(forceWithDirection);
    }
}
