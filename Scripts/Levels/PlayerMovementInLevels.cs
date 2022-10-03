using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementInLevels : MonoBehaviour
{
    [SerializeField]
    private float p_Speed;

    [SerializeField]
    private float p_JumpForce;

    private Rigidbody p_Player;

    private float direction;


    // Start is called before the first frame update
    void Start()
    {
        p_Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float v_Horizontal = Input.GetAxis("Horizontal");
        float v_vertical = Input.GetAxis("Vertical");
        Vector3 velocity = p_Player.velocity;
        velocity.z = -v_Horizontal * p_Speed;
        velocity.x = v_vertical * p_Speed;
        p_Player.velocity = velocity;

        if(Input.GetKey(KeyCode.Space))
        {
            p_Player.AddForce(Vector3.up * p_JumpForce, ForceMode.Impulse);
        }
    }
}
