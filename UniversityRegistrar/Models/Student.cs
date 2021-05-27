using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int Year { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get;}

    //  public virtual ICollection<StudentItem> JoinEntities { get;}
  }
}