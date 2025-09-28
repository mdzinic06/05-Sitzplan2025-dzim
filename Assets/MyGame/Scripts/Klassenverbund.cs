using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Klassenverbund : MonoBehaviour
{

    public TMP_Text text_input;
    public TMP_Text text_text_field;

    public TMP_Text text_input_table;
    public TMP_Text text_output_text_field_table;
    Student student = new Student();

    void Start()
    {
        text_input.text = "Enter ID";
        text_text_field.text = " ";
        text_input_table.text = "Enter table number!";
        text_output_text_field_table.text = " ";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
