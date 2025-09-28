using UnityEngine;

public class Mensch : MonoBehaviour
{
    private string name_;
    private int age_;
    private bool anwesenheit_;
    private int id_;

    public void set_name(string name)
    {
        this.name_ = name;
    }

    public void set_age(int age)
    {
        this.age_ = age;
    }

    public void set_anwesenheit(bool anwesenheit)
    {
        this.anwesenheit_ = anwesenheit;
    }

    public void set_id(int id)
    {
        this.id_ = id;
    }

    public string get_name()
    {
        return name_;
    }

    public int get_age()
    {
        return age_;
    }

    public bool get_anwesenheit()
    {
        return anwesenheit_;
    }

    public int get_id()
    {
        return id_;
    }
}
