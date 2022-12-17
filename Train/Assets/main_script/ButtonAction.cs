using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public GameObject panelGameObject;
    public GameObject imageGameObject;
    public Button button;

    private void Start()
    {
        bool isActive = false;

        button.onClick.AddListener(() =>
        {
            isActive = !isActive;
            panelGameObject.SetActive(isActive);
            imageGameObject.SetActive(isActive);
        });
    }
}