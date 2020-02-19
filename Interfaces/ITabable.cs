using System.Windows.Forms;
using NoAutocar.Views;

namespace NoAutocar
{
    /// <summary>
    /// Use this interface to allow the <see cref="MainView"/> to use a <see cref=" System.Windows.Forms.Form"/>
    /// </summary>
    public interface ITabable
    {
        Form Form { get; }
        string TabName { get; }
    }
}
