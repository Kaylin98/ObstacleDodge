using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 2f;
    MeshRenderer meshRenderer;
    new Rigidbody rigidbody;
    
    void Start()
    {
       meshRenderer = GetComponent<MeshRenderer>();
       rigidbody = GetComponent<Rigidbody>();

       meshRenderer.enabled = false;
       rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
