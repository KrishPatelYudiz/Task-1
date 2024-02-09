using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform SideA;
    [SerializeField] private Transform SideB;
    [SerializeField] private float time = 5;


    Vector3 MidPointe;
    void Start()
    {
        transform.position = SideA.transform.position;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = SideA.transform.position;
        }
        float speed = Vector3.Distance(SideA.transform.position, SideB.transform.position) / time;
        transform.position = Vector3.Slerp(transform.position, SideB.transform.position, Time.fixedDeltaTime * speed);
    }
}
