/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/2/2021
 * Time: 2:23 PM
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
    public class MenuHelpCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileHelp()
        {
        	
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks Help
            Mouse.MoveTo(435, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks Button
            Mouse.MoveTo(000, 000);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
    }
}
