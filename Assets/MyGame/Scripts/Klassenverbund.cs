using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Globalization;
public class Klassenverbund : MonoBehaviour
{

    public TMP_Text text_input;
    public TMP_Text text_text_field;

    public TMP_Text text_input_table;
    public TMP_Text text_output_text_field_table;

    [SerializeField] private TMP_InputField inputField;

    Student student;

    void Start()
    {
        text_input.text = "Enter Chair ID";
        text_text_field.text = " ";
        text_input_table.text = "Enter table number!";
        text_output_text_field_table.text = " ";

        string input_from_user = inputField.text;
        int.TryParse(input_from_user, out int number);
        print_table_seats(number);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void print_table_seats(int input)
    {
        if (input == 1 || input == 2)
        {
            text_text_field.text = "Hier sitzen Vinzent und Gabriel";
        }
        else if (input == 3 || input == 4)
        {
            text_text_field.text = "Hier sitzen Viktor und Emil";
        }
        else if (input == 5 || input == 6)
        {
            text_text_field.text = "Hier sitzt keiner";
        }
        else if (input == 7 || input == 8)
        {
            text_text_field.text = "Hier sitzen Muhammed und Mirza";
        }
        else if (input == 9 || input == 10)
        {
            text_text_field.text = "Hier sitzen Semin und Jai";
        }
        else if (input == 11 || input == 12)
        {
            text_text_field.text = "Hier sitzen Jonah und Simon";
        }
        else if (input == 13 || input == 14)
        {
            text_text_field.text = "Hier sitzen Medine und Sham";
        }
        else if (input == 15 || input == 16)
        {
            text_text_field.text = "Hier sitzen David D und Georg";
        }
        else if (input == 17 || input == 18)
        {
            text_text_field.text = "Hier sitzt nur Fabian";
        }
        else if (input == 19 || input == 20)
        {
            text_text_field.text = "Hier sitzen David G und Jakob";
        }
        else if (input == 21 || input == 22)
        {
            text_text_field.text = "Hier sitzen Lukas und Luca";
        }

    }
}
