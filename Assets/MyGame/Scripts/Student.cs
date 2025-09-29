using UnityEngine;

public class Student : MonoBehaviour
{
    [SerializeField] private string name_student;
    [SerializeField] private string age_student;
    [SerializeField] private string anwesenheit_student;
    [SerializeField] private string id_student;

    private Mensch mensch;  // hier speichern wir die Daten

    void Start()
    {
        mensch = new Mensch();
        mensch.set_name(name_student);
        mensch.set_age(age_student);
        mensch.set_anwesenheit(anwesenheit_student);
        mensch.set_id(id_student);

        // Ausgabe in der Konsole
        Debug.Log($"Schüler: Name={mensch.get_name()}, " +
                  $"Alter={mensch.get_age()}, " +
                  $"Anwesenheit={mensch.get_anwesenheit()}, " +
                  $"ID={mensch.get_id()}");
    }

    public Mensch GetMensch()
    {
        return mensch;
    }
}
