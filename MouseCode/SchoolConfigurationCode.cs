/*
 * Created by Ranorex
 * User: mfunston
 * Date: 7/6/2021
 * Time: 3:32 PM
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
    public class SchoolConfigurationCode
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PutSubjectInSlatesClassGroup()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(657, 749);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(632, 825);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void AskForClassGroup()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(657, 749);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(632, 800);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void NoChange()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(657, 749);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(632, 774);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void AskForClassGroupIfDifferent()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(657, 749);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(632, 850);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void RoomCheckBox()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(1077, 670);
            Mouse.Click();
            Delay.Milliseconds(300);

            
        }

        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SalutationCheckBox()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(861, 670);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }


        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void InstructorCheckBox()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(648, 670);
            Mouse.Click();
            Delay.Milliseconds(300);


            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void GradeCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(435, 670);
            Mouse.Click();
            Delay.Milliseconds(300);

            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void UserFourCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(1104, 559);
            Mouse.Click();
            Delay.Milliseconds(300);

        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void UserThreeCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(1104, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void UserTwoCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(919, 559);
            Mouse.Click();
            Delay.Milliseconds(300);

           
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void UserOneCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(918, 525);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDLengthFour()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 563);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 692);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDLengthThree()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 563);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 670);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDLengthTwo()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 563);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 639);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDLengthOne()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 563);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 618);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDLengthUnlimited()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 563);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 592);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDLengthFour()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 653);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDLengthThree()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 626);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDLengthTwo()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 601);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDLengthOne()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 578);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDLengthUnlimited()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(881, 525);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(852, 556);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void RequireSalutationForStaffCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 600);
            Mouse.Click();
            Delay.Milliseconds(300);
           
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TeacherIDCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 564);
            Mouse.Click();
            Delay.Milliseconds(300);


            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentIDCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 528);
            Mouse.Click();
            Delay.Milliseconds(300);


            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ApplySoftTouchToTeacherPackageCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(652, 419);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StyleCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(861, 388);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void NoNameCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(652, 452);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void RetouchCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(652, 419);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void BlankCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(652, 388);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void NameCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 452);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SoftTouchCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 419);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PackageCheckBox()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(437, 388);
            Mouse.Click();
            Delay.Milliseconds(300);

            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ExposureTest()
        {
        	        	        	
            // Details display only
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void BackgroundTest()
        {
        	        	        	
            // Details display only
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void CameraSettings()
        {
        	        	        	
            // Details display only
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ImageOrientation()
        {
        	        	        	
            // Details display only
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void MaxImageorSubject()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(988, 251);
            Mouse.Click();
            Delay.Milliseconds(300);

            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void OfferTypePrepay()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(980, 254);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(984, 278);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void OfferTypeProof()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(980, 254);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(984, 309);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionFallImaginationNonGreenScreenBright()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(991, 554);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(885, 546);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionConfirmation()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(991, 554);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(885, 528);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionCommunion()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(991, 554);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // move and click
            Mouse.MoveTo(885, 499);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionGraduation()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 545);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionPromOrDance()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 521);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionSeniorExpressMilestones()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 494);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionMilestonesNonGreenscreen()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 475);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionWhenIGrowUp()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 443);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionGenericMixed()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 420);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionFallImaginationBright()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 394);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionISSGenericHoriz()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 365);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionISSGenericVertical()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 342);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionHolidayGreenScreen()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 321);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionKGMilestones()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 397);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionMilestone()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 273);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PromotionFallImagination()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(986, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // move and click
            Mouse.MoveTo(930, 243);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentOrderByClass()
        {
        	        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(678, 292);
            Mouse.Click();
            Delay.Milliseconds(150);

            // move and click
            Mouse.MoveTo(668, 345);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // type 
            Keyboard.Press("ABC");
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void StudentOrderRandom()
        {
        	        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            // move and click
            Mouse.MoveTo(678, 292);
            Mouse.Click();
            Delay.Milliseconds(150);

            // move and click
            Mouse.MoveTo(668, 320);
            Mouse.Click();
            Delay.Milliseconds(300);
            
            // type 
            Keyboard.Press("ABC");
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SchoolConfigurationPost()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(674, 393);
            Mouse.Click();
            Delay.Milliseconds(300);

            // post
            Mouse.MoveTo(666, 306);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SchoolConfigurationLive()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(674, 393);
            Mouse.Click();
            Delay.Milliseconds(300);

            // live
            Mouse.MoveTo(666, 283);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SchoolConfigurationSaveClose()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(687, 812);
            Mouse.Click();
            Delay.Milliseconds(300);
            
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void SchoolConfigurationPhotographerInitials()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Mouse.MoveTo(595, 216);
            Mouse.Click();
            Delay.Milliseconds(300);

            // type admin
            Keyboard.Press("ABC");
            Delay.Milliseconds(300);
            
        }
        
    }
}
