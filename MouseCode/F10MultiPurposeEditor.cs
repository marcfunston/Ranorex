/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/7/2021
 * Time: 12:02 PM
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
    public class F10MultiPurposeEditor
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ByClass()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(58, 91);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ByGrade()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(142, 91);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ApplySettingToAllClasses()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(472, 952);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SetFirst()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(1093, 953);
            Mouse.Click();
            Delay.Milliseconds(300);
            
             // clicks button
            Mouse.MoveTo(1051, 603);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SetSecond()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(1093, 953);
            Mouse.Click();
            Delay.Milliseconds(300);
            
             // clicks button
            Mouse.MoveTo(1051, 626);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void Apply()
        {
        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(1372, 955);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CloseDataCheck()
        {
        	        	        	        	        	        	        	        	        	        	        	        	        	        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks button
            Mouse.MoveTo(1658, 12);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }

    }
}
