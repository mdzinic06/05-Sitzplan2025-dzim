using UnityEngine;

public class Student : MonoBehaviour
{
    [SerializeField] private Mensch[] student_array = new Mensch[19];

    void Start()
    {

        for (int i = 0; i < student_array.Length; i++)
        {
            Mensch m = student_array[i];

            if (m != null)
            {
                Debug.Log($"Schüler {i + 1}: " +
                          $"Name={m.get_name()}, " +
                          $"Alter={m.get_age()}, " +
                          $"Anwesenheit={m.get_anwesenheit()}, " +
                          $"ID={m.get_id()}");
            }
        }
    }
}
