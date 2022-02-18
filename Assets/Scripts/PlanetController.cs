using UnityEngine;

public class PlanetController : MonoBehaviour
{
    [SerializeField] private Planet planet;
    
    private void Start()
    {
        transform.localScale *= planet.scale;
        transform.position = Vector3.right * planet.distanceFromCenter;
        GetComponent<MeshRenderer>().material = planet.material;
    }

    private void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, planet.yearDuration * Time.deltaTime);
        transform.Rotate(Vector3.up, 1 / planet.dayDuration);
    }
}
