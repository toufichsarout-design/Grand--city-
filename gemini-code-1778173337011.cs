using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update() {
        // Simple movement for a Grand City style character
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        // Logic for weapons would be added here
        if (Input.GetButtonDown("Fire1")) {
            ShootWeapon();
        }
    }

    void ShootWeapon() {
        Debug.Log("Weapon Fired!");
    }
}