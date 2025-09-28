using UnityEngine;

public class Mensch : MonoBehaviour
{
    [SerializeField] private string name_;
    [SerializeField] private string age_;
    [SerializeField] private string anwesenheit_;
    [SerializeField] private string id_;


    public void set_name(string name)
    {
        this.name_ = name;
    }

    public void set_age(string age)
    {
        this.age_ = age;
    }

    public void set_anwesenheit(string anwesenheit)
    {
        this.anwesenheit_ = anwesenheit;
    }

    public void set_id(string id)
    {
        this.id_ = id;
    }

    public string get_name()
    {
        return name_;
    }

    public string get_age()
    {
        return age_;
    }

    public string get_anwesenheit()
    {
        return anwesenheit_;
    }

    public string get_id()
    {
        return id_;
    }
}
