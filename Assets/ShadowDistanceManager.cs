using UnityEngine;

public class ShadowDistanceManager : MonoBehaviour
{
    public Transform player;
    public float maxShadowDistance = 50f;
    public float minShadowDistance = 10f;
    public float adjustSpeed = 10f;

    private void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(player.position, Camera.main.transform.position);
            float targetShadowDistance = Mathf.Clamp(distance, minShadowDistance, maxShadowDistance);
            QualitySettings.shadowDistance = Mathf.Lerp(QualitySettings.shadowDistance, targetShadowDistance, Time.deltaTime * adjustSpeed);
        }
    }
}
