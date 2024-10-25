using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform orbitCenter; // Reference to the object around which the planet orbits (e.g., the sun)
    public float orbitSpeed = 1f; // Speed of orbit
    public float rotationSpeed = 2f; // Speed of planet's rotation around its axis

    void Update()
    {
        // Rotate around the orbit center
        transform.RotateAround(orbitCenter.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Rotate the planet around its own axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}