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
    ///The TimerMode recording.
    /// </summary>
    [TestModule("18a36b11-3b89-4d4f-86f2-d967bf559f58", ModuleType.Recording, 1)]
    public partial class TimerMode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_iOS_modifiedRepository repository.
        /// </summary>
        public static SSPC_iOS_modifiedRepository repo = SSPC_iOS_modifiedRepository.Instance;

        static TimerMode instance = new TimerMode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TimerMode()
        {
            TimerModeHours = "2";
            TimerModeMinutes = "1";
            TimerHrs = "1";
            TimerMins = "56";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TimerMode Instance
        {
            get { return instance; }
        }

#region Variables

        string _TimerModeHours;

        /// <summary>
        /// Gets or sets the value of variable TimerModeHours.
        /// </summary>
        [TestVariable("d1a165cc-2228-44c2-9d43-71ea5888f548")]
        public string TimerModeHours
        {
            get { return _TimerModeHours; }
            set { _TimerModeHours = value; }
        }

        string _TimerModeMinutes;

        /// <summary>
        /// Gets or sets the value of variable TimerModeMinutes.
        /// </summary>
        [TestVariable("43dd0c8e-111c-44d4-a36d-d67a4ce2b4b9")]
        public string TimerModeMinutes
        {
            get { return _TimerModeMinutes; }
            set { _TimerModeMinutes = value; }
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
        /// Gets or sets the value of variable TimerHrs.
        /// </summary>
        [TestVariable("1b102ef9-ff5b-4e44-8612-3f7b5714a428")]
        public string TimerHrs
        {
            get { return repo.TimerHrs; }
            set { repo.TimerHrs = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimerMins.
        /// </summary>
        [TestVariable("f7ab5b1f-be92-4631-b607-03b2faff3912")]
        public string TimerMins
        {
            get { return repo.TimerMins; }
            set { repo.TimerMins = value; }
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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Timer_Mode' at Center", repo.ComPentairPentairhome.Timer_ModeInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.Timer_Mode.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.TimerHours.timerHrs'.", repo.ComPentairPentairhome.TimerHours.timerHrsInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.TimerHours.timerHrs.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Hours(repo.ComPentairPentairhome.Hours.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'ComPentairPentairhome.TimeMinutes.TimerMins'.", repo.ComPentairPentairhome.TimeMinutes.TimerMinsInfo, new RecordItemIndex(9));
            repo.ComPentairPentairhome.TimeMinutes.TimerMins.Select();
            Delay.Milliseconds(0);
            
            Swipe_gesture_Minutes(repo.ComPentairPentairhome.Minutes.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.timerStart' at Center", repo.ComPentairPentairhome.timerStartInfo, new RecordItemIndex(12));
            repo.ComPentairPentairhome.timerStart.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
