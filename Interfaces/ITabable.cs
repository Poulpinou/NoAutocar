using System.Windows.Forms;

namespace NoAutocar
{
    interface ITabable
    {
        Form Form { get; }
        string TabName { get; }
    }
}
