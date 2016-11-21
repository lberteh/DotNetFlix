/*
 * App: DotNETFlix 
 * Author: Lucas Berté Schoenardie
 * Student #: 200322197
 * App Creation Date: 11/01/2016
 * App Description: Online movie rental/purchase application
 */

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
        // inititalizes youtubeurl string
        string youTubeURL = CustomerForm.selectedMovie.TrailerURL;

        // extracts the youtube video ID using a regex
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

        // load the trailer with a web browser component
        private void TrailerForm_Load(object sender, EventArgs e)
        {
            webBrowserTrailer.Navigate($"http://youtube.com/v/{videoID}?version=3");
        }

        
    }
}
