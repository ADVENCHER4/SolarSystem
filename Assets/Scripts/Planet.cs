using UnityEngine;
[CreateAssetMenu(fileName = "New planet", menuName = "Planet")]
public class Planet : ScriptableObject
{
    public float distanceFromCenter;
    public float dayDuration;
    public float yearDuration;
    public float scale;
    public Material material;
    
}
