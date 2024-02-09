using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public int ktish;
    public void Respawn()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 0.5f, Random.Range(-4.0f, 4.0f));

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Respawn();
        }
    }
}
