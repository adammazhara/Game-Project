using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Shooting : MonoBehaviour {
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public static bool active = false;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.F) && active) {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation); // create bullet object
        }
    }
}
