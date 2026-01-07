using UnityEngine;

public class TriggerProjectiile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;

    

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
       {
        SetActive(true);
       }
    }

    void SetActive(bool isActive)
    {
        projectile.SetActive(isActive);
        projectile2.SetActive(isActive);
        projectile3.SetActive(isActive);
        projectile4.SetActive(isActive);
        projectile5.SetActive(isActive);

        Destroy(gameObject);
    }
}
