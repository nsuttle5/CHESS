using UnityEngine;

public class HandMove : MonoBehaviour
{
    public float offset;
    public float turnAmount = 1;
    private Vector3 targetPos;

    void Start()
    {
        targetPos = transform.parent.position;
    }
    public void Move(Transform button)
    {
        targetPos = new Vector3(transform.parent.position.x, button.position.y + offset, transform.parent.position.z);
    }
    
    void Update()
    {
        transform.position += (targetPos - transform.position) * .05f;
        transform.eulerAngles = new Vector3(0, 0, (targetPos.y - transform.position.y) * turnAmount);
    }
}
