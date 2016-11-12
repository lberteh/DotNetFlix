using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFlix
{
    public partial class TrailerForm : Form
    {
        string youTubeURL = CustomerForm.selectedMovie.TrailerURL;

        public string videoID
        {
            get
            {
                var youTubeMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(youTubeURL);
                return youTubeMatch.Success ? youTubeMatch.Groups[1].Value : string.Empty;
            }
        }

        public TrailerForm()
        {
            InitializeComponent();
        }

        private void TrailerForm_Load(object sender, EventArgs e)
        {
            webBrowserTrailer.Navigate($"http://youtube.com/v/{videoID}?version=3");
        }

        
    }
}
