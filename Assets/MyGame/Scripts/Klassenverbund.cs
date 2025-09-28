using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Klassenverbund : MonoBehaviour
{

    public TMP_Text text_input;
    Student student = new Student();

    void Start()
    {
        text_input.text = "Enter ID";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
