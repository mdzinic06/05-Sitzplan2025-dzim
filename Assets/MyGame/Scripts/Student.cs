using UnityEngine;

public class Student : UnityEngine.MonoBehaviour
{
    public string name_student;
    public int age_student;
    public bool anwesenheit_student;
    public int id_student;



    void Start()
    {
        Mensch mensch = new Mensch();
        mensch.set_name(name_student);
        mensch.set_age(age_student);
        mensch.set_anwesenheit(anwesenheit_student);
        mensch.set_id(id_student);

        Debug.Log("Student Name: " + mensch.get_name() + ", " + "Student Age:" + ", " + mensch.get_age() + ", " + "Student Anwesenheit:" + ", " + mensch.get_anwesenheit() + ", " + "Student ID:" + ", " + mensch.get_id() + " ");
    }
}
