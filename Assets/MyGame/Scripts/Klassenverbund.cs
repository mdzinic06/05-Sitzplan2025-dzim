using UnityEngine;
using TMPro;

public class Klassenverbund : MonoBehaviour
{
    [Header("UI Elemente")]
    public TMP_Text text_input;
    public TMP_Text text_text_field;

    [SerializeField] private TMP_InputField inputField;

    void Start()
    {
        text_input.text = "Enter Table ID";
        text_text_field.text = "";


        inputField.onEndEdit.AddListener(HandleInput);
    }


    private void HandleInput(string input_from_user)
    {
        if (int.TryParse(input_from_user, out int number))
        {
            print_table_seats(number);
        }
        else
        {
            text_text_field.text = "Bitte eine gültige Zahl eingeben!";
        }
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
        else
        {
            text_text_field.text = "Kein Platz für diese Nummer gefunden!";
        }
    }
}
