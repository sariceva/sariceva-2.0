using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;

        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Player collided with {collision.gameObject.name}");

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Player collided with an enemy!");
            Destroy(gameObject);
        }
    }
}
