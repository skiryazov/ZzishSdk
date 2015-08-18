using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using Lexicum.ZzishApiClient;

namespace ZzishTest
{
    public partial class ApiDemoForm : Form
    {
        ZzishApiSession session;
        public ApiDemoForm()
        {
            InitializeComponent();

            txtGroupCode.Text = ConfigurationManager.AppSettings["ZzishTestClassCode"];
        }

        private ZzishApiSession Session
        {
            get
            {
                if (session == null)
                    session = new ZzishApiSession();

                return session;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                // the debug version of the method call dumps the whole object returned. Switch to the regular version if this is not of interest
                print(Session.RegisterUserDebug("Kunyo Conev"));
                //print("Success, status: " + Session.RegisterUser("Kunyo Conev", "2114").ToString());
            }
            catch (Exception ex)
            {
                print(ex.ToString());
            }
        }


        private void btnActivity_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasCode())
                    print(Session.RegisterActivityDebug("Sample Activity", txtGroupCode.Text));
                    //print(Session.RegisterActivity("Sample Activity", txtGroupCode.Text));
            }
            catch (Exception ex)
            {
                print(ex.ToString());
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasCode())
                    // register action has just one version and it works like the debug versions of the other methods
                    print(Session.RegisterAction(Session.ActivityId, "sample action", 3.ToString(), "value"));
            }
            catch (Exception ex)
            {
                print(ex.ToString());
            }
        }

        private void print(String text)
        {
            txtResult.Text = text + "\r\n\r\n" + txtResult.Text;
        }
        
        private Boolean hasCode()
        {
            if (String.IsNullOrEmpty(txtGroupCode.Text))
            {
                MessageBox.Show(
                @"You haven't provided a classroom code neither in the config file nor in the textbox in the upper-right corner. This call cannot be executed without a classroom code. Please go to http://zzish.com, create a classroom and input the code here in the demo app.",
                "Missing group code", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void ApiDemoForm_Shown(object sender, EventArgs e)
        {
            String appId = ConfigurationManager.AppSettings["ZzishAppId"];
            if (String.IsNullOrEmpty(appId))
            {
                MessageBox.Show(
                @"You haven't provided a Zzish App ID in the app.config file. Please obtain the same from http://zzish.com and add it to the config file.

The demo app will now exit.", "Missing App ID in config", MessageBoxButtons.OK);
                this.Close();
            }

        }

    }
}

//Copyright 2015 Lexicum

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
