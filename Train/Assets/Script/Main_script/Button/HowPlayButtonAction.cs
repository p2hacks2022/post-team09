using UnityEngine;
using UnityEngine.UI;

public class HowPlayButtonAction : MonoBehaviour
{
    public GameObject imageGameObject;
    public Button button;

    private void Start()
    {
        bool isActive = false;

        button.onClick.AddListener(() =>
        {
            isActive = !isActive;
            imageGameObject.SetActive(isActive);
        });
    }
}