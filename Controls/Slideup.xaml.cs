using System.Windows.Controls;

namespace AppboyUI.Phone.Controls {
  public partial class Slideup : UserControl {
    public Slideup() {
      InitializeComponent();
    }

    public void SetText(string text) {
      SlideupTextBlock.Text = text;      
    }
  }
}
