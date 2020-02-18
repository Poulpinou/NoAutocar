using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoAutocar.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            BuildTabs();
        }

        void BuildTabs() {
            AddTab(new FindTab());
            AddTab(new LineEditorTab());
        }

        void AddTab(ITabable tabable) {
            Form form = tabable.Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;

            TabPage tabPage = new TabPage(tabable.TabName);
            tabPage.Controls.Add(form);

            tabControl.TabPages.Add(tabPage);
        }
    }
}
