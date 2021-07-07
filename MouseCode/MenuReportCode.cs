/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/2/2021
 * Time: 2:22 PM
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
    public class MenuReportCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void GroupContactSheet()
        {
        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 198);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ProofStaffRoster()
        {
        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 172);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ProofClassRoster()
        {
        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 145);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CameraCards()
        {
        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 122);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void RetakeStatisticsReport()
        {
        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 98);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void Reports()
        {
        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(202, 65);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileReport()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Reports
            Mouse.MoveTo(190, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks Button
            Mouse.MoveTo(000, 000);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
    }
}
