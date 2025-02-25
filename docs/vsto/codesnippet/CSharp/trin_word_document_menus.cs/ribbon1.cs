﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon1();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace CS
{
    [ComVisible(true)]
    public class Ribbon1 : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon1()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("CS.Ribbon1.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, select the Ribbon XML item in Solution Explorer and then press F1

        //<Snippet6>
        public void ButtonClick(Office.IRibbonControl control)
        {
            if (control.Id == "BoldButton")
            {
                if (Globals.ThisDocument.selectedBookmark.Bold == 
                    Globals.ThisDocument.WordTrue)
                {
                    Globals.ThisDocument.selectedBookmark.Bold = 
                        Globals.ThisDocument.WordFalse;
                }
                else
                {
                    Globals.ThisDocument.selectedBookmark.Bold = 
                        Globals.ThisDocument.WordTrue;
                }
            }
            else if (control.Id == "ItalicButton")
            {
                if (Globals.ThisDocument.selectedBookmark.Italic == 
                    Globals.ThisDocument.WordTrue)
                {
                    Globals.ThisDocument.selectedBookmark.Italic = 
                        Globals.ThisDocument.WordFalse;
                }
                else
                {
                    Globals.ThisDocument.selectedBookmark.Italic = 
                        Globals.ThisDocument.WordTrue;
                }
            }

        }
        //</Snippet6>
        //<Snippet5>
        public bool GetVisible(Office.IRibbonControl control)
        {
            if (control.Id == "BoldButton")
            {
                if (Globals.ThisDocument.showBoldButton == true)
                {
                    Globals.ThisDocument.showBoldButton = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (control.Id == "ItalicButton")
            {
                if (Globals.ThisDocument.showItalicButton == true)
                {
                    Globals.ThisDocument.showItalicButton = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
       
        }
 
        //</Snippet5>
        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
