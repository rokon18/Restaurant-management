using System.Windows.Forms;

namespace Restaurant_management
{
    public static class Session
    {
      
        public static string CurrentUsername { get; set; }
        public static Form LastForm { get; set; }
    }
}
