/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/2/2021
 * Time: 2:20 PM
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
    public class MenuFileCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileSetup()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(333, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileMergeCamera()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(315, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileNonDataImages()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(282, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileImportNewSchool()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(258, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileExportData()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(235, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileImportData()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(212, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileReviewJob()
        {
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(185, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileSubmitJob()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(165, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileBurnJob()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(140, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFilePhotoReport()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(120, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFileImportPEF()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(95, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFilePreEntry()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(70, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
            
           
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MainMenuFile()
        {
        	
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // clicks File
            Mouse.MoveTo(26, 44);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // clicks File
            Mouse.MoveTo(000, 71);
            Mouse.Click();
            Delay.Milliseconds(300);
        	
        }
        
        
        
        
    }
}
