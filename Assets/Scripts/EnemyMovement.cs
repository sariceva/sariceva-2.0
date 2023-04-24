using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float maxMovementX = 0;
    public float maxMovementZ = 0;

    public float speedX = 0;
    public float speedZ = 0;

    public int directionX = 1;
    public int directionZ = 1;

    private Transform myTransform;
    private float startX;
    private float startZ;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.GetComponent<Transform>();
        startX = myTransform.position.x;
        startZ = myTransform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        SetDirectionX();
        SetDirectionZ();
        Move();
    }

    void Move()
    {
        myTransform.Translate(speedX * directionX * Time.deltaTime, 0, speedZ * directionZ * Time.deltaTime);
    }

    void SetDirectionX()
    {        
        if(Math.Abs(myTransform.position.x - startX) >= maxMovementX)
        {
            directionX = -directionX;
        }
    }

    void SetDirectionZ()
    {
        if (Math.Abs(myTransform.position.z - startZ) >= maxMovementZ)
        {
            directionZ = -directionZ;
        }
    }
}
