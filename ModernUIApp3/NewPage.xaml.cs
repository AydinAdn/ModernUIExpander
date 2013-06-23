// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewPage.xaml.cs" company="I wish...">
//   Use it as you like
// </copyright>
// <summary>
//   Interaction logic for NewPage.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ModernUIExpander
{
    /// <summary>
    /// Interaction logic for NewPage.xaml
    /// </summary>
    public partial class NewPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPage"/> class.
        /// </summary>
        public NewPage()
        {
            this.InitializeComponent();

            for (var i = 1; i <= 15; i++)
            {
                this.ExpanderListBox.Items.Add(string.Format("Example 2: In List. Item number: {0}", i));
            }
        }
    }
}
