using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonPopup : MonoBehaviour
{
    public GameObject popupText;

    private void Start()
    {
        popupText.SetActive(false); // Hide popup text at start
    }

    public void ShowPopup()
    {
        popupText.SetActive(true); // Show popup text
        StartCoroutine(HidePopupAfterDelay(2f)); // Hide after 2 seconds
    }

    private IEnumerator HidePopupAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        popupText.SetActive(false); // Hide popup text
    }
}
