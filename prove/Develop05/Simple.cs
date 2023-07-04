
public class Simple:Goal
{

   private bool isComplete;

   public Simple(string name, int points) : base(name, points)
   {
        isComplete = false;
   }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override void MarkComplete()
    {
        isComplete = true;
    }

    public override string GetProgress()
    {
       return "In Progress";
    }
}