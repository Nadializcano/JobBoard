using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    private string _title;
    private string _description;
    private string _contact;
    private int _id;
    private static List<JobOpening> _instances = new List<JobOpening> {};

    public JobOpening (string title, string description, string contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetContact()
    {
      return _contact;
    }

    public void SetContact(string newContact)
    {
      _contact = newContact;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static JobOpening Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
