using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    void Start()
    {
        //Add a force at start
        rb.AddForce(0,0,forwardForce);
    }
    // FixedUpdate is called once per frame(Use update if not physic related)
    /*void Update()
    {

    }*/
    void FixedUpdate()
    {
        // force per frame
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y<=-1f)
        {
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}
