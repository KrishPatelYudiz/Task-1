using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform SideA;
    [SerializeField] private Transform SideB;
    [SerializeField] private float time = 5;

    public float currentDistance = 0;

    void Start()
    {
        transform.position = SideA.transform.position;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = SideA.transform.position;
        }
        float distance = Time.deltaTime / time;
        transform.position = Vector3.Slerp(SideA.transform.position, SideB.transform.position, currentDistance);
        currentDistance += distance;
    }
}
