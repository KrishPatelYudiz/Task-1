using UnityEngine;

public class TriangleScript : MonoBehaviour
{

    [SerializeField] private GameObject circleObject;
    [SerializeField] private float speed = 2;
    [SerializeField] public CircleScript circleScript;
    private void Start()
    {
        circleScript.Respawn();
    }
    private void FixedUpdate()
    {
        if (!IsRotating())
        {

            Move();
        }
    }

    void Move()
    {


        var Distance = circleObject.transform.position - transform.position;

        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        if (Distance.sqrMagnitude < 1)
        {
            circleScript.Respawn();
        }
    }

    bool IsRotating()
    {
        var temp = transform.rotation;
        var direction = circleObject.transform.position - transform.position;
        var dir = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, dir, Time.fixedDeltaTime * speed);

        if (temp == transform.rotation)
            return false;
        return true;
    }

}
