using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpinSpeed = 0f;
    [SerializeField] float ySpinSpeed = 0f;
    [SerializeField] float zSpinSpeed = 0f;
    
    void Update()
    {
        transform.Rotate(xSpinSpeed * Time.deltaTime, ySpinSpeed * Time.deltaTime, zSpinSpeed * Time.deltaTime);
    }
}
