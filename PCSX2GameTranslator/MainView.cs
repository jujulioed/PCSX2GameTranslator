

namespace PCSX2GameTranslator
{
    public partial class MainView : Form
    {

        public PrintPCSX2Screen Pcsx2Process;

        public MainView()
        {
            InitializeComponent();
            Pcsx2Process = new PrintPCSX2Screen();
            Pcsx2Process.GetPCSX2Process();

        }
    }
}
