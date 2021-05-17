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
    ///The ScheduleHealthTestWeekly recording.
    /// </summary>
    [TestModule("d8d8f3e6-092b-46e0-8f41-630fb24571c6", ModuleType.Recording, 1)]
    public partial class ScheduleHealthTestWeekly : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_BVTRepository repository.
        /// </summary>
        public static SSPC_iOS_BVTRepository repo = SSPC_iOS_BVTRepository.Instance;

        static ScheduleHealthTestWeekly instance = new ScheduleHealthTestWeekly();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduleHealthTestWeekly()
        {
            GoogleSearchTimeNow = "Queen Creek Time Now";
            TimeValue = "";
            TimeHrs = "";
            TimeMins = "";
            TimeAmPm = "";
            Day = "";
            DateSchedule = "";
            DateNumber = "5";
            DateMonth = "";
            DayInitial = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduleHealthTestWeekly Instance
        {
            get { return instance; }
        }

#region Variables

        string _GoogleSearchTimeNow;

        /// <summary>
        /// Gets or sets the value of variable GoogleSearchTimeNow.
        /// </summary>
        [TestVariable("f8be9bd5-26d6-42bf-adcd-03960593299c")]
        public string GoogleSearchTimeNow
        {
            get { return _GoogleSearchTimeNow; }
            set { _GoogleSearchTimeNow = value; }
        }

        string _TimeValue;

        /// <summary>
        /// Gets or sets the value of variable TimeValue.
        /// </summary>
        [TestVariable("f54dd1a2-b7bc-4bb1-aafa-b187432c3514")]
        public string TimeValue
        {
            get { return _TimeValue; }
            set { _TimeValue = value; }
        }

        string _Day;

        /// <summary>
        /// Gets or sets the value of variable Day.
        /// </summary>
        [TestVariable("e10db8e2-d6e4-4d12-980f-65fa2ee24f23")]
        public string Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        string _DateSchedule;

        /// <summary>
        /// Gets or sets the value of variable DateSchedule.
        /// </summary>
        [TestVariable("f3374c0e-71b1-42ec-b1fc-48181808eca4")]
        public string DateSchedule
        {
            get { return _DateSchedule; }
            set { _DateSchedule = value; }
        }

        string _DateMonth;

        /// <summary>
        /// Gets or sets the value of variable DateMonth.
        /// </summary>
        [TestVariable("89df9b24-9dab-4e29-8e68-3dca71b725d7")]
        public string DateMonth
        {
            get { return _DateMonth; }
            set { _DateMonth = value; }
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
        /// Gets or sets the value of variable DayInitial.
        /// </summary>
        [TestVariable("becd7252-82e5-4ef9-9e93-f9b451e5130f")]
        public string DayInitial
        {
            get { return repo.DayInitial; }
            set { repo.DayInitial = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeHrs.
        /// </summary>
        [TestVariable("39b05a18-3243-4949-9964-57ceb2891b97")]
        public string TimeHrs
        {
            get { return repo.TimeHrs; }
            set { repo.TimeHrs = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeMins.
        /// </summary>
        [TestVariable("c2bce66a-552c-486b-a326-cd5cdcbc0efb")]
        public string TimeMins
        {
            get { return repo.TimeMins; }
            set { repo.TimeMins = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAmPm.
        /// </summary>
        [TestVariable("803b4172-fd3d-4e7f-bf51-84463ebeaee7")]
        public string TimeAmPm
        {
            get { return repo.TimeAmPm; }
            set { repo.TimeAmPm = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DateNumber.
        /// </summary>
        [TestVariable("cc943f3b-3900-4e08-8aaf-f66de3aa2368")]
        public string DateNumber
        {
            get { return repo.DateNumber; }
            set { repo.DateNumber = value; }
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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHTWeeklySelec' at Center", repo.ComPentairPentairhome.ScheduleHTWeeklySelecInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.ScheduleHTWeeklySelec.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.google.com' with browser 'Chrome' in maximized mode.", new RecordItemIndex(10));
            Host.Current.OpenBrowser("http://www.google.com", "Chrome", "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Queen Creek time now' with focus on 'Google.GoogleInput'.", repo.Google.GoogleInputInfo, new RecordItemIndex(12));
            repo.Google.GoogleInput.PressKeys("Queen Creek time now");
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
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.day' and assigning its value to variable 'Day'.", repo.Google.dayInfo, new RecordItemIndex(18));
            Day = repo.Google.day.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            dayExtracter(Day);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.Date' and assigning its value to variable 'DateSchedule'.", repo.Google.DateInfo, new RecordItemIndex(20));
            DateSchedule = repo.Google.Date.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(21));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Google'.", repo.Google.SelfInfo, new RecordItemIndex(22));
            Host.Current.CloseApplication(repo.Google.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleDay' at Center", repo.ComPentairPentairhome.ScheduleDayInfo, new RecordItemIndex(23));
            repo.ComPentairPentairhome.ScheduleDay.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(24));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "User", TimeHrs, new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(26));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Hours.SchduleHrs'.", repo.ComPentairPentairhome.Hours.SchduleHrsInfo, new RecordItemIndex(27));
            repo.ComPentairPentairhome.Hours.SchduleHrs.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Hours(repo.ComPentairPentairhome.Hours.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Minutes.ScheduleMins'.", repo.ComPentairPentairhome.Minutes.ScheduleMinsInfo, new RecordItemIndex(30));
            repo.ComPentairPentairhome.Minutes.ScheduleMins.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Minutes(repo.ComPentairPentairhome.Minutes.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(32));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.AMPM.ScheduleAMPM'.", repo.ComPentairPentairhome.AMPM.ScheduleAMPMInfo, new RecordItemIndex(33));
            repo.ComPentairPentairhome.AMPM.ScheduleAMPM.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_AMPM(repo.ComPentairPentairhome.AMPM.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(35));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleSave' at Center", repo.ComPentairPentairhome.ScheduleSaveInfo, new RecordItemIndex(36));
            repo.ComPentairPentairhome.ScheduleSave.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(37));
            Delay.Duration(60000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(39));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
