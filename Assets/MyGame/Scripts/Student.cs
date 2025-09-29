using UnityEngine;
using System.Collections.Generic;

public class Student : MonoBehaviour
{
    [SerializeField] private List<Mensch> schuelerListe = new List<Mensch>();

    void Start()
    {
        // Alle Schüler ausgeben
        for (int i = 0; i < schuelerListe.Count; i++)
        {
            Mensch m = schuelerListe[i];
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
