using AppboyPlatform.Phone.Managers;
using System.Windows.Controls;

namespace AppboyUI.Phone.Factories {
  public class SlideupFactory : ISlideupFactory {
    public UserControl GetSlideup(string message) {
      var slideup = new Controls.Slideup();
      slideup.SetText(message);
      return slideup;
    }
  }
}
