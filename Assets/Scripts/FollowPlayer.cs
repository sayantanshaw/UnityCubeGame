
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player_info;
    public Vector3 offset; 
    // Update is called once per frame
    void Update()
    {
        transform.position = player_info.position+offset;
    }
}
