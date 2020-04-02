using System.Windows.Forms;

namespace WinFormsComboBoxAutoFitContent
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();

            var dataSource1 = new string[] {"Item1" , "Very, very long string for example", "Item3", "Item4"};
            this.comboBox1.DataSource = dataSource1;
            this.comboBox1.DropDownWidth = this.DropDownWidth(dataSource1);
        }

        #endregion


        #region Methods

        private int DropDownWidth(string[] data)
        {
            int maxWidth = 0;
            var label = new Label();

            foreach (string item in data)
            {
                label.Text = item;

                if (label.PreferredWidth > maxWidth)
                {
                    maxWidth = label.PreferredWidth;
                }
            }

            label.Dispose();
            return maxWidth;
        }

        #endregion
    }
}
