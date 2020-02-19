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
    /// <summary>
    /// This is the main viex of the application, it will conatinas every other <see cref="Form"/>s in its <see cref="TabControl"/> as <see cref="ITabable"/>s
    /// </summary>
    public partial class MainView : Form
    {
        #region Private Fields
        Dictionary<string, TabPage> pages;
        #endregion

        #region Constructors
        public MainView()
        {
            pages = new Dictionary<string, TabPage>();
            InitializeComponent();
            BuildTabs();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Add a new <see cref="TabPage"/> in the <see cref="TabControl"/> (it replaces any <see cref="TabPage"/> with the same name)
        /// </summary>
        /// <param name="tabable">The <see cref="ITabable"/> to add</param>
        /// <param name="switchToNewTab">If true, the newly added tab will become the active one</param>
        public void AddTab(ITabable tabable, bool switchToNewTab = false) {
            Form form = tabable.Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;

            TabPage tabPage = new TabPage(tabable.TabName);
            tabPage.Controls.Add(form);

            if (pages.ContainsKey(tabable.TabName))
            {
                tabControl.TabPages.Remove(pages[tabable.TabName]);
                pages[tabable.TabName] = tabPage;
            }
            else
            {
                pages.Add(tabable.TabName, tabPage);
            }
            
            tabControl.TabPages.Add(tabPage);

            if(switchToNewTab == true)
            {
                ChangeTab(tabable);
            }
        }

        /// <summary>
        /// Changes the active tab
        /// </summary>
        /// <param name="tabable">The new active tab</param>
        public void ChangeTab(ITabable tabable)
        {
            if(pages.ContainsKey(tabable.TabName))
                tabControl.SelectedTab = pages[tabable.TabName];
        }

        /// <summary>
        /// Closes the provided tab
        /// </summary>
        /// <param name="tabable">The <see cref="ITabable"/> to close</param>
        public void CloseTab(ITabable tabable)
        {
            if (pages.ContainsKey(tabable.TabName))
            {
                tabControl.SelectedTab = tabControl.TabPages[tabControl.TabPages.IndexOf(pages[tabable.TabName]) - 1];
                tabControl.TabPages.Remove(pages[tabable.TabName]);
                pages.Remove(tabable.TabName);
            }
            
        }
        #endregion

        #region Private Methods
        void BuildTabs()
        {
            AddTab(new FindTab());
            AddTab(new LinesTab());
            AddTab(new LineEditorTab());
        }
        #endregion
    }
}
