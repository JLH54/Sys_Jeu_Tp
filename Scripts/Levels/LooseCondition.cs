using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCondition : MonoBehaviour
{
    [SerializeField]
    private float[] p_startingPosition;

    private Rigidbody p_player;
    // Start is called before the first frame update
    void Start()
    {
        p_player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //suppose to return to the spawning position
        if (p_player.velocity.y >= 10)
        {
            transform.position = new Vector3(p_startingPosition[0], p_startingPosition[1], p_startingPosition[2]);
        }
    }
}
