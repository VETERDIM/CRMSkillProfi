using System.Windows.Media.Imaging;

namespace AdminConsol.Models
{
    class MainItem
    {
        public string Id { get; set; }
        public string LabelH1TextBox { get; set; }
        public string LabelH3TextBox { get; set; }
        public string LabelDescriptionTextBox { get; set; }
        public string UserNameTextBox { get; set; }
        public string EmailTextBox { get; set; }
        public string ButtonChatTextBox { get; set; }
        public byte[] Data { get; set; }
        public byte[] DataLogo { get; set; }
        public BitmapFrame PhotoMain { get; set; }
        public BitmapFrame LogoImg { get; set; }
    }
}
