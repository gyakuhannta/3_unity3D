using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] Collider playerCollider;
    [SerializeField] Enemy[] enemies;
  
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var subVec = playerCollider.bounds.center - rb.position;
        subVec.y = 0;
        
    }
}
