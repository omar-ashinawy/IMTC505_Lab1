using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private float force;
        
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(new  Vector3(0, force, 0));
    }
}
