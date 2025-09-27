using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Button_SceneChanger : MonoBehaviour
{
    public TMP_Text text_;

    private void Awake()
    {
        text_.text = "Start";
    }

    public void ChangingScene_()
    {
        SceneManager.LoadScene("MainScene.unity.meta");
    }

}
