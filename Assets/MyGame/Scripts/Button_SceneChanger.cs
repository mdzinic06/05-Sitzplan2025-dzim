using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Button_SceneChanger : MonoBehaviour
{
    public TMP_Text text_;
    public TMP_Text text_for_screen;

    private void Awake()
    {
        text_.text = "Start";
        text_for_screen.text = "Klick Start to start in the Classroom 4BHITS!";
    }

    public void ChangingScene_()
    {
        SceneManager.LoadScene("MainScene.unity.meta");
    }

}
