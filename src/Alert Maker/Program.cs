using System.Windows.Forms;

namespace Alert_Maker
{
  internal static class Program
  {
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new AlertMakerForm());
    }
  }
}
