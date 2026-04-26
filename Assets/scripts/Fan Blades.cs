using UnityEngine;
 
public class FanSpin : MonoBehaviour
{
    public float speed = 200f;
 
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}