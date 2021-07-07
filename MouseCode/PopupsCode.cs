/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/2/2021
 * Time: 2:24 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace DesktopCamdex
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class PopupsCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateGroupSubjectRecordsOk()
        {
        	       	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // click no
            Mouse.MoveTo(923, 589);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateGroupSubjectRecordsNo()
        {
        	       	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // click no
            Mouse.MoveTo(992, 600);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateGroupSubjectRecordsYes()
        {
        	       	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // click no
            Mouse.MoveTo(907, 600);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PerformStartupExposureTestNo()
        {
        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // click no
            Mouse.MoveTo(981, 590);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // click ok
            Mouse.MoveTo(1004, 590);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PerformStartupExposureTest()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // click yes
            Mouse.MoveTo(904, 590);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void DigitalCamdexFailedContraints()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(1000, 590);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateTeacherRecordsYes()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(917, 620);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateTeacherRecordsNo()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(1001, 620);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CreateTeacherRecordsOk()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(906, 589);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void BatchFaceFinderYes()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(895, 593);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void BatchFaceFinderNo()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(979, 594);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
    }
}
