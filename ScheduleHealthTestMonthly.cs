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
    ///The ScheduleHealthTestMonthly recording.
    /// </summary>
    [TestModule("f9153055-21b9-4911-a207-042de76e1046", ModuleType.Recording, 1)]
    public partial class ScheduleHealthTestMonthly : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_modifiedRepository repository.
        /// </summary>
        public static SSPC_iOS_modifiedRepository repo = SSPC_iOS_modifiedRepository.Instance;

        static ScheduleHealthTestMonthly instance = new ScheduleHealthTestMonthly();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduleHealthTestMonthly()
        {
            TimeValue = "";
            DateSchedule = "";
            TimeHrs = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduleHealthTestMonthly Instance
        {
            get { return instance; }
        }

#region Variables

        string _TimeValue;

        /// <summary>
        /// Gets or sets the value of variable TimeValue.
        /// </summary>
        [TestVariable("870b59e1-b8f4-4c6c-a5a6-71a397b44c22")]
        public string TimeValue
        {
            get { return _TimeValue; }
            set { _TimeValue = value; }
        }

        string _DateSchedule;

        /// <summary>
        /// Gets or sets the value of variable DateSchedule.
        /// </summary>
        [TestVariable("6dfa3646-8693-45f7-8d23-37c4a748e0f1")]
        public string DateSchedule
        {
            get { return _DateSchedule; }
            set { _DateSchedule = value; }
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
        /// Gets or sets the value of variable DateNumber.
        /// </summary>
        [TestVariable("e38a7db9-e45e-4146-afa5-cf333057007c")]
        public string DateNumber
        {
            get { return repo.DateNumber; }
            set { repo.DateNumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeHrs.
        /// </summary>
        [TestVariable("3ddb319f-a384-4a9d-bd2a-7d33a6da1b1c")]
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
            
            try {
                //Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.FrequencyDaily' at Center", repo.ComPentairPentairhome.FrequencyDailyInfo, new RecordItemIndex(4));
                //repo.ComPentairPentairhome.FrequencyDaily.Touch();
                //Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.FrequencyWeekly' at Center", repo.ComPentairPentairhome.FrequencyWeeklyInfo, new RecordItemIndex(5));
                //repo.ComPentairPentairhome.FrequencyWeekly.Touch();
                //Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.FrequencyMonthly' at Center", repo.ComPentairPentairhome.FrequencyMonthlyInfo, new RecordItemIndex(6));
                repo.ComPentairPentairhome.FrequencyMonthly.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.FrequencyDisable' at Center", repo.ComPentairPentairhome.FrequencyDisableInfo, new RecordItemIndex(7));
                //repo.ComPentairPentairhome.FrequencyDisable.Touch();
                //Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHealthTestDropDown' at Center", repo.ComPentairPentairhome.ScheduleHealthTestDropDownInfo, new RecordItemIndex(10));
            repo.ComPentairPentairhome.ScheduleHealthTestDropDown.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleHTmonthlySelect' at Center", repo.ComPentairPentairhome.ScheduleHTmonthlySelectInfo, new RecordItemIndex(12));
            repo.ComPentairPentairhome.ScheduleHTmonthlySelect.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.google.com' with browser 'Chrome' in maximized mode.", new RecordItemIndex(14));
            Host.Current.OpenBrowser("http://www.google.com", "Chrome", "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(15));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Queen Creek time now' with focus on 'Google.GoogleInput'.", repo.Google.GoogleInputInfo, new RecordItemIndex(16));
            repo.Google.GoogleInput.PressKeys("Queen Creek time now");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(17));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Google.GoogleSearchButton'.", repo.Google.GoogleSearchButtonInfo, new RecordItemIndex(18));
            repo.Google.GoogleSearchButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(19));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.Time' and assigning its value to variable 'TimeValue'.", repo.Google.TimeInfo, new RecordItemIndex(20));
            TimeValue = repo.Google.Time.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            timeExtracter();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'Google.Date' and assigning its value to variable 'DateSchedule'.", repo.Google.DateInfo, new RecordItemIndex(22));
            DateSchedule = repo.Google.Date.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            dateAndMonthExtracter();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(24));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.MonthlyDayClick' at Center", repo.ComPentairPentairhome.MonthlyDayClickInfo, new RecordItemIndex(25));
            repo.ComPentairPentairhome.MonthlyDayClick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(26));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Monthlytimeclick' at Center", repo.ComPentairPentairhome.MonthlytimeclickInfo, new RecordItemIndex(27));
            repo.ComPentairPentairhome.Monthlytimeclick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(28));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Hours.SchduleHrs'.", repo.ComPentairPentairhome.Hours.SchduleHrsInfo, new RecordItemIndex(29));
            repo.ComPentairPentairhome.Hours.SchduleHrs.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Hours(repo.ComPentairPentairhome.Hours.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(31));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.Minutes.ScheduleMins'.", repo.ComPentairPentairhome.Minutes.ScheduleMinsInfo, new RecordItemIndex(32));
            repo.ComPentairPentairhome.Minutes.ScheduleMins.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Minutes(repo.ComPentairPentairhome.Minutes.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(34));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.AMPM.ScheduleAMPM'.", repo.ComPentairPentairhome.AMPM.ScheduleAMPMInfo, new RecordItemIndex(35));
            repo.ComPentairPentairhome.AMPM.ScheduleAMPM.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_AMPM(repo.ComPentairPentairhome.AMPM.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(37));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ScheduleSave' at Center", repo.ComPentairPentairhome.ScheduleSaveInfo, new RecordItemIndex(38));
            repo.ComPentairPentairhome.ScheduleSave.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(39));
            Delay.Duration(60000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
