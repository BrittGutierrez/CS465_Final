using UnityEngine;
 
public class FanSpin : MonoBehaviour
{
    //how fast we want the fan to spin
    public float speed = 200f;
 
    void Update()
    {
        //animates the spinning blades
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}