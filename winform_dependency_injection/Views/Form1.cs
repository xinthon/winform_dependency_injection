namespace winform_dependency_injection.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ResizeEnd += (object? sender, EventArgs e) =>
            {
                this.WindowState= FormWindowState.Maximized;
            };
        }
    }
}