﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SSPC_iOS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ScheduleHealthTestDaily recording.
    /// </summary>
    [TestModule("cb522195-7c18-4737-816a-396bcfdcbc0e", ModuleType.Recording, 1)]
    public partial class ScheduleHealthTestDaily : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_BVTRepository repository.
        /// </summary>
        public static SSPC_iOS_BVTRepository repo = SSPC_iOS_BVTRepository.Instance;

        static ScheduleHealthTestDaily instance = new ScheduleHealthTestDaily();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduleHealthTestDaily()
        {
            TimeValue = "";
            Day = "";
            DateSchedule = "";
            googleSearchText = "Queen Creek time now";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduleHealthTestDaily Instance
        {
            get { return instance; }
        }

#region Variables

        string _TimeValue;

        /// <summary>
        /// Gets or sets the value of variable TimeValue.
        /// </summary>
        [TestVariable("7f22479f-0bb6-4e39-8172-e813d2708bc1")]
        public string TimeValue
        {
            get { return _TimeValue; }
            set { _TimeValue = value; }
        }

        string _Day;

        /// <summary>
        /// Gets or sets the value of variable Day.
        /// </summary>
        [TestVariable("29b252f2-c77e-4155-8e56-97d0ee5d9a9b")]
        public string Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        string _DateSchedule;

        /// <summary>
        /// Gets or sets the value of variable DateSchedule.
        /// </summary>
        [TestVariable("93db9715-8a35-4224-82f0-8367dcb82660")]
        public string DateSchedule
        {
            get { return _DateSchedule; }
            set { _DateSchedule = value; }
        }

        string _googleSearchText;

        /// <summary>
        /// Gets or sets the value of variable googleSearchText.
        /// </summary>
        [TestVariable("9d3a3f3a-c3aa-442f-8e84-e2718cc00d86")]
        public string googleSearchText
        {
            get { return _googleSearchText; }
            set { _googleSearchText = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Nickname.
        /// </summary>
        [TestVariable("15db34cc-b901-4dc4-b385-f561e02f4c65")]
        public string Nickname
        {
            get { return repo.Nickname; }
            set { repo.Nickname = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeHrs.
        /// </summary>
        [TestVariable("4c89d4ac-cd54-4534-9ba8-28963ed19e39")]
        public string TimeHrs
        {
            get { return repo.TimeHrs; }
            set { repo.TimeHrs = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeMins.
        /// </summary>
        [TestVariable("0fc1fa44-b84e-4da3-ae5c-308f2eb3cdaf")]
        public string TimeMins
        {
            get { return repo.TimeMins; }
            set { repo.TimeMins = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAmPm.
        /// </summary>
        [TestVariable("4409e7c2-cdf4-45b3-a06b-7e20294e66c0")]
        public string TimeAmPm
        {
            get { return repo.TimeAmPm; }
            set { repo.TimeAmPm = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome.HomeIcon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SSPCtileClick' at Center", repo.ComPentairPentairhome.SSPCtileClickInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.SSPCtileClick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.FrequencySelection' at Center", repo.ComPentairPentairhome.FrequencySelectionInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.FrequencySelection.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHealthTestDropDown' at Center", repo.ComPentairPentairhome.ScheduleHealthTestDropDownInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.ScheduleHealthTestDropDown.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHTDailySelect' at Center", repo.ComPentairPentairhome.ScheduleHTDailySelectInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.ScheduleHTDailySelect.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.google.com' with browser 'Chrome' in maximized mode.", new RecordItemIndex(10));
            Host.Current.OpenBrowser("http://www.google.com", "Chrome", "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$googleSearchText' with focus on 'Google.GoogleInput'.", repo.Google.GoogleInputInfo, new RecordItemIndex(12));
            repo.Google.GoogleInput.PressKeys(googleSearchText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Google.GoogleSearchButton'.", repo.Google.GoogleSearchButtonInfo, new RecordItemIndex(14));
            repo.Google.GoogleSearchButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(15));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.Time' and assigning its value to variable 'TimeValue'.", repo.Google.TimeInfo, new RecordItemIndex(16));
            TimeValue = repo.Google.Time.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            timeExtracter();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(18));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Google'.", repo.Google.SelfInfo, new RecordItemIndex(19));
            Host.Current.CloseApplication(repo.Google.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(20));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Hours.SchduleHrs'.", repo.ComPentairPentairhome.Hours.SchduleHrsInfo, new RecordItemIndex(21));
            repo.ComPentairPentairhome.Hours.SchduleHrs.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Hours(repo.ComPentairPentairhome.Hours.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(23));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Minutes.ScheduleMins'.", repo.ComPentairPentairhome.Minutes.ScheduleMinsInfo, new RecordItemIndex(24));
            repo.ComPentairPentairhome.Minutes.ScheduleMins.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Minutes(repo.ComPentairPentairhome.Minutes.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(26));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.AMPM.ScheduleAMPM'.", repo.ComPentairPentairhome.AMPM.ScheduleAMPMInfo, new RecordItemIndex(27));
            repo.ComPentairPentairhome.AMPM.ScheduleAMPM.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_AMPM(repo.ComPentairPentairhome.AMPM.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleSave' at Center", repo.ComPentairPentairhome.ScheduleSaveInfo, new RecordItemIndex(30));
            repo.ComPentairPentairhome.ScheduleSave.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(31));
            Delay.Duration(60000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(33));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
